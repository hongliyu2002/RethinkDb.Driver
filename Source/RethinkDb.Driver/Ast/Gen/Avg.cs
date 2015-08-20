



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Avg : ReqlQuery {
    
        public Avg (object arg) : this(new Arguments(arg), null) {
        }
        public Avg (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Avg (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.AVG, args, optargs) {
        }

        protected Avg (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Avg FromArgs(params object[] args){
               return new Avg (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
