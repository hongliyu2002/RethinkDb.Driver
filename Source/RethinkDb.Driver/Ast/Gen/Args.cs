



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Args : ReqlQuery {
    
        public Args (object arg) : this(new Arguments(arg), null) {
        }
        public Args (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Args (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.ARGS, args, optargs) {
        }

        protected Args (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Args FromArgs(params object[] args){
               return new Args (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
