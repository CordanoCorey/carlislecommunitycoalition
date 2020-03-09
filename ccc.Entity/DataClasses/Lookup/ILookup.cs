using System;
using System.Collections.Generic;
using System.Text;

namespace ccc.Entity.DataClasses
{
  public interface ILookup
  {
    int Id { get; set; }
    string Name { get; set; }
    bool IsActive { get; set; }
  }
}
