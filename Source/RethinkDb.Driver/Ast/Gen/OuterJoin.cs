



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class OuterJoin : ReqlQuery {
    
        public OuterJoin (object arg) : this(new Arguments(arg), null) {
        }
        public OuterJoin (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public OuterJoin (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.OUTER_JOIN, args, optargs) {
        }

        protected OuterJoin (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static OuterJoin FromArgs(params object[] args){
               return new OuterJoin (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
