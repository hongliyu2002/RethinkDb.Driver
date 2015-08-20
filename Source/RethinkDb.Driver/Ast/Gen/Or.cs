



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Or : ReqlQuery {
    
        public Or (object arg) : this(new Arguments(arg), null) {
        }
        public Or (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Or (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.OR, args, optargs) {
        }

        protected Or (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Or FromArgs(params object[] args){
               return new Or (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
