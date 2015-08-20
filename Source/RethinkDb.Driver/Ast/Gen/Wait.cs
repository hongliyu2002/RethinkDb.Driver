



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Wait : ReqlQuery {
    
        public Wait (object arg) : this(new Arguments(arg), null) {
        }
        public Wait (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Wait (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.WAIT, args, optargs) {
        }

        protected Wait (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Wait FromArgs(params object[] args){
               return new Wait (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
