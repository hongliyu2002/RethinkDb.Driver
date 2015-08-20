



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class TypeOf : ReqlQuery {
    
        public TypeOf (object arg) : this(new Arguments(arg), null) {
        }
        public TypeOf (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public TypeOf (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.TYPE_OF, args, optargs) {
        }

        protected TypeOf (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static TypeOf FromArgs(params object[] args){
               return new TypeOf (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
