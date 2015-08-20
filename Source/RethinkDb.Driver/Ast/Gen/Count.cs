



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Count : ReqlQuery {
    
        public Count (object arg) : this(new Arguments(arg), null) {
        }
        public Count (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Count (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.COUNT, args, optargs) {
        }

        protected Count (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Count FromArgs(params object[] args){
               return new Count (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
