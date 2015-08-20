



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class IsEmpty : ReqlQuery {
    
        public IsEmpty (object arg) : this(new Arguments(arg), null) {
        }
        public IsEmpty (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public IsEmpty (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.IS_EMPTY, args, optargs) {
        }

        protected IsEmpty (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static IsEmpty FromArgs(params object[] args){
               return new IsEmpty (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
