



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Between : ReqlQuery {
    
        public Between (object arg) : this(new Arguments(arg), null) {
        }
        public Between (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Between (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.BETWEEN, args, optargs) {
        }

        protected Between (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Between FromArgs(params object[] args){
               return new Between (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
