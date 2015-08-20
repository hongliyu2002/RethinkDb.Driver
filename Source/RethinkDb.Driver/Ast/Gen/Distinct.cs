



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Distinct : ReqlQuery {
    
        public Distinct (object arg) : this(new Arguments(arg), null) {
        }
        public Distinct (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Distinct (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DISTINCT, args, optargs) {
        }

        protected Distinct (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Distinct FromArgs(params object[] args){
               return new Distinct (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
