



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Fill : ReqlQuery {
    
        public Fill (object arg) : this(new Arguments(arg), null) {
        }
        public Fill (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Fill (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.FILL, args, optargs) {
        }

        protected Fill (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Fill FromArgs(params object[] args){
               return new Fill (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
