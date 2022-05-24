using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult // cok prpo olacak
    {
        public T Data{ get; }   // new DataResult<category>(ResultStatus.Success,cateory)
                                // new DataResult<IList<category>>(ResultStatus.Success,cateoryList)
        
    
    
    }
}
