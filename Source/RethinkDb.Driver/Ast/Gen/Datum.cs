



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Datum : ReqlQuery {
    
        public Datum (object arg) : this(new Arguments(arg), null) {
        }
        public Datum (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Datum (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DATUM, args, optargs) {
        }

        protected Datum (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Datum FromArgs(params object[] args){
               return new Datum (new Arguments(args), null);
        }

    /* Special Methods */

    }
}
