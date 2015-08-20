



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Time : ReqlQuery {
    
        public Time (object arg) : this(new Arguments(arg), null) {
        }
        public Time (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Time (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.TIME, args, optargs) {
        }

        protected Time (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Time FromArgs(params object[] args){
               return new Time (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
