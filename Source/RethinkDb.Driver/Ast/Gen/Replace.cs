



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Replace : ReqlQuery {
    
        public Replace (object arg) : this(new Arguments(arg), null) {
        }
        public Replace (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Replace (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.REPLACE, args, optargs) {
        }

        protected Replace (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Replace FromArgs(params object[] args){
               return new Replace (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
