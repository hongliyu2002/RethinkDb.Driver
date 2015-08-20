



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Mod : ReqlQuery {
    
        public Mod (object arg) : this(new Arguments(arg), null) {
        }
        public Mod (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Mod (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.MOD, args, optargs) {
        }

        protected Mod (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Mod FromArgs(params object[] args){
               return new Mod (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
