import { TypeConstructor } from './models';

export function build<T>(ctor: TypeConstructor<T>, ...args): T {
  const instance = new ctor();
  return args.reduce((acc, next) => {
    let ret;
    try {
      ret = Object.assign(acc, next);
    } catch (e) {
      console.warn(e);
      ret = acc;
    } finally {
      return ret;
    }
  }, instance);
}

export function buildEmptyCells(rows: number, cols: number): boolean[][] {
  return new Array(rows).map(x => new Array(cols).map(y => false));
}

export function calculateAge(birthday): number {
  // birthday is a date
  const ageDifMs = Date.now() - new Date(birthday).getTime();
  const ageDate = new Date(ageDifMs); // miliseconds from epoch
  return Math.abs(ageDate.getUTCFullYear() - 1970);
}

export function integerArray(n: number): number[] {
  return Array.from(Array(n).keys());
}

export function positiveIntegerArray(n: number): number[] {
  return integerArray(n).map(x => x + 1);
}

export function shuffle(array) {
  let currentIndex = array.length,
    temporaryValue,
    randomIndex;

  // While there remain elements to shuffle...
  while (0 !== currentIndex) {
    // Pick a remaining element...
    randomIndex = Math.floor(Math.random() * currentIndex);
    currentIndex -= 1;

    // And swap it with the current element.
    temporaryValue = array[currentIndex];
    array[currentIndex] = array[randomIndex];
    array[randomIndex] = temporaryValue;
  }

  return array;
}

export function toPx(n: number): string {
  return `${n}px`;
}

export function sum(arr: number[]): number {
  return arr.reduce((acc, x) => acc + x, 0);
}

export function average(arr: number[]): number {
  return sum(arr) / Math.max(arr.length, 1);
}
