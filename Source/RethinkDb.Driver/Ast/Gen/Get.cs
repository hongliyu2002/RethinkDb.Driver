



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Get : ReqlQuery {
    
        public Get (object arg) : this(new Arguments(arg), null) {
        }
        public Get (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Get (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.GET, args, optargs) {
        }

        protected Get (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Get FromArgs(params object[] args){
               return new Get (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
