import { Component, OnInit, HostListener } from '@angular/core';
import { MatIconRegistry, MatSnackBar, MatDialog } from '@angular/material';
import { DomSanitizer } from '@angular/platform-browser';
import { Router, ActivatedRoute } from '@angular/router';
import {
  build,
  WindowResize,
  LookupService,
  Lookup,
  SmartComponent,
  ConfigActions,
  WindowActions,
  RouterService,
  routeNameSelector,
  StorageService,
  messageSelector,
  AutoLogoutComponent,
  userLastActiveSelector,
  authenticatedSelector,
  MessageSubscription
} from '@caiu/library';
import { Store } from '@ngrx/store';
import { Observable, Subscription } from 'rxjs';

import { environment } from '../environments/environment';
import { PlayersActions, PlayerActions } from './shared/actions';

@Component({
  selector: 'ccc-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent extends SmartComponent implements OnInit {
  errorMessage$: Observable<string>;
  lastActive = new Date();
  lastActive$: Observable<Date>;
  loggedIn = false;
  loggedIn$: Observable<boolean>;
  loggingOut = false;
  routeName = '';
  routeName$: Observable<string>;
  time;
  toast$: Observable<string>;
  messages = [
    build(MessageSubscription, {
      action: PlayersActions.POST,
      channel: 'TOASTS',
      mapper: e => e.message || `Player saved successfully!`
    }),
    build(MessageSubscription, {
      action: PlayersActions.POST_ERROR,
      channel: 'ERRORS',
      mapper: e => e.message || `Error saving agenda.`
    }),
    build(MessageSubscription, {
      action: PlayerActions.PUT,
      channel: 'TOASTS',
      mapper: e => e.message || `Player saved successfully!`
    }),
    build(MessageSubscription, {
      action: PlayerActions.PUT_ERROR,
      channel: 'ERRORS',
      mapper: e => e.message || `Error saving agenda.`
    })
  ];

  constructor(
    iconRegistry: MatIconRegistry,
    sanitizer: DomSanitizer,
    public store: Store<any>,
    public storage: StorageService,
    private routerService: RouterService,
    private router: Router,
    private route: ActivatedRoute,
    public lookup: LookupService,
    private snackBar: MatSnackBar,
    public dialog: MatDialog
  ) {
    super(store);
    // To avoid XSS attacks, the URL needs to be trusted from inside of your application.
    const avatarsSafeUrl = sanitizer.bypassSecurityTrustResourceUrl(
      './assets/avatars.svg'
    );
    iconRegistry.addSvgIconSetInNamespace('avatars', avatarsSafeUrl);
    // this.lastActive$ = userLastActiveSelector(store);
    // this.loggedIn$ = authenticatedSelector(store);
    this.routeName$ = routeNameSelector(store);
    this.toast$ = messageSelector(store, 'TOASTS');
    this.errorMessage$ = messageSelector(store, 'ERRORS');
  }

  get errorMessageChanges(): Subscription {
    return this.errorMessage$.subscribe(x => {
      this.showErrorMessage(x);
    });
  }

  get localStorageActions(): string[] {
    return [];
  }

  get localStorageMapper(): (s: any) => any {
    return state => {
      // const currentUser = build(CurrentUser, state ? state['currentUser'] : {});
      return {};
    };
  }

  get lookupKeys(): string[] {
    return [];
  }

  get lookupValues(): Lookup[] {
    return [
      // build(Lookup, { key: 'StatCategories', values: STAT_CATEGORIES })
    ];
  }

  get sessionStorageActions(): string[] {
    return [];
  }

  get sessionStorageMapper(): (s: any) => any {
    return state => { };
  }

  get toastChanges(): Subscription {
    return this.toast$.subscribe(x => {
      this.openSnackBar(x);
    });
  }

  ngOnInit() {
    this.sync(['routeName']);
    this.storage.init(
      this.localStorageMapper,
      this.sessionStorageMapper,
      this.localStorageActions,
      this.sessionStorageActions
    );
    this.loadConfiguration();
    this.initStorage();
    this.initLookup();
    setTimeout(() => {
      if (!this.time) {
        this.autoLogout();
      }
    }, 1800000);
    this.addSubscription(this.toastChanges);
    this.addSubscription(this.errorMessageChanges);
    this.onInit();
  }

  autoLogout() {
    // if (this.loggedIn && !this.loggingOut) {
    //   this.loggingOut = true;
    //   this.openDialog(AutoLogoutComponent, {
    //     width: '600px'
    //   });
    // }
  }

  closeDialog(result: any) {
    if (this.loggingOut && result) {
      this.logout();
    }
    this.loggingOut = false;
    super.closeDialog(result);
  }

  loadConfiguration() {
    this.store.dispatch(ConfigActions.initialize(environment));
  }

  initLookup() {
    this.lookup.load(this.lookupKeys, this.lookupValues);
  }

  initStorage() {
    this.storage.init(
      this.localStorageMapper,
      this.sessionStorageMapper,
      this.localStorageActions,
      this.sessionStorageActions
    );
  }

  logout() {
    // this.dispatch(CurrentUserActions.logout());
  }

  openSnackBar(message: string) {
    this.snackBar.open(message, 'Close', {
      duration: 3000
    });
  }

  showErrorMessage(message: string) {
    this.snackBar.open(message, 'Close', {
      duration: 5000,
      verticalPosition: 'top',
      panelClass: 'snackbar-error'
    });
  }

  @HostListener('window:mousemove')
  resetTimer() {
    // console.log(new Date().getTime() - this.lastActive.getTime());
    // this.dispatch({ type: CurrentUserActions.RESET_LAST_ACTIVE });
    clearTimeout(this.time);
    this.time = setTimeout(() => {
      this.autoLogout();
    }, 1800000); // logout after 30 minutes
    // }, 60000);
  }

  @HostListener('window:load', ['$event'])
  onLoad(e: any) {
    const windowHeight =
      e && e.currentTarget && e.currentTarget.innerHeight
        ? e.currentTarget.innerHeight
        : 0;
    const windowWidth =
      e && e.currentTarget && e.currentTarget.innerWidth
        ? e.currentTarget.innerWidth
        : 0;
    this.dispatch(
      WindowActions.resize(build(WindowResize, { windowHeight, windowWidth }))
    );
  }

  @HostListener('window:resize', ['$event'])
  onResize(e: any) {
    const windowHeight =
      e && e.currentTarget && e.currentTarget.innerHeight
        ? e.currentTarget.innerHeight
        : 0;
    const windowWidth =
      e && e.currentTarget && e.currentTarget.innerWidth
        ? e.currentTarget.innerWidth
        : 0;
    this.dispatch(
      WindowActions.resize(build(WindowResize, { windowHeight, windowWidth }))
    );
  }
}
