



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Delete : ReqlQuery {
    
        public Delete (object arg) : this(new Arguments(arg), null) {
        }
        public Delete (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Delete (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DELETE, args, optargs) {
        }

        protected Delete (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Delete FromArgs(params object[] args){
               return new Delete (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
