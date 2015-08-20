



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Info : ReqlQuery {
    
        public Info (object arg) : this(new Arguments(arg), null) {
        }
        public Info (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Info (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.INFO, args, optargs) {
        }

        protected Info (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Info FromArgs(params object[] args){
               return new Info (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
