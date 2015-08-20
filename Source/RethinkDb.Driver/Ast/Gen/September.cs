



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class September : ReqlQuery {
    
        public September (object arg) : this(new Arguments(arg), null) {
        }
        public September (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public September (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.SEPTEMBER, args, optargs) {
        }

        protected September (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static September FromArgs(params object[] args){
               return new September (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
