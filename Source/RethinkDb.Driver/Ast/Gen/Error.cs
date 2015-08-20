



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Error : ReqlQuery {
    
        public Error (object arg) : this(new Arguments(arg), null) {
        }
        public Error (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Error (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.ERROR, args, optargs) {
        }

        protected Error (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Error FromArgs(params object[] args){
               return new Error (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
