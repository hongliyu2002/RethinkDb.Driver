



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class HasFields : ReqlQuery {
    
        public HasFields (object arg) : this(new Arguments(arg), null) {
        }
        public HasFields (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public HasFields (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.HAS_FIELDS, args, optargs) {
        }

        protected HasFields (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static HasFields FromArgs(params object[] args){
               return new HasFields (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
