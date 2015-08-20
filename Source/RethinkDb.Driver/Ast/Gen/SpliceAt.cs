



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class SpliceAt : ReqlQuery {
    
        public SpliceAt (object arg) : this(new Arguments(arg), null) {
        }
        public SpliceAt (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public SpliceAt (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.SPLICE_AT, args, optargs) {
        }

        protected SpliceAt (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static SpliceAt FromArgs(params object[] args){
               return new SpliceAt (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
