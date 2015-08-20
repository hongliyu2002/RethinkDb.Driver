



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Minval : ReqlQuery {
    
        public Minval (object arg) : this(new Arguments(arg), null) {
        }
        public Minval (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Minval (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.MINVAL, args, optargs) {
        }

        protected Minval (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Minval FromArgs(params object[] args){
               return new Minval (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
