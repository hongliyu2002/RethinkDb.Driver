



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast.Gen {
    public class Table : ReqlQuery {
    
        public Table (object arg) : this(new Arguments(arg), null) {
        }
        public Table (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Table (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.TABLE, args, optargs) {
        }

        protected Table (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Table FromArgs(params object[] args){
               return new Table (new Arguments(args), null);
        }

    /* Special Methods */
            public Get get (params object[] fields){
                    return new Get (this, new Arguments(fields), new OptArgs());
            }
            public GetAll getAll (params object[] fields){
                    return new GetAll (this, new Arguments(fields), new OptArgs());
            }
            public Between between (params object[] fields){
                    return new Between (this, new Arguments(fields), new OptArgs());
            }
            public Insert insert (params object[] fields){
                    return new Insert (this, new Arguments(fields), new OptArgs());
            }
            public Config config (params object[] fields){
                    return new Config (this, new Arguments(fields), new OptArgs());
            }
            public Status status (params object[] fields){
                    return new Status (this, new Arguments(fields), new OptArgs());
            }
            public Wait wait (params object[] fields){
                    return new Wait (this, new Arguments(fields), new OptArgs());
            }
            public Reconfigure reconfigure (params object[] fields){
                    return new Reconfigure (this, new Arguments(fields), new OptArgs());
            }
            public Rebalance rebalance (params object[] fields){
                    return new Rebalance (this, new Arguments(fields), new OptArgs());
            }
            public Sync sync (params object[] fields){
                    return new Sync (this, new Arguments(fields), new OptArgs());
            }
            public IndexCreate indexCreate (params object[] fields){
                    return new IndexCreate (this, new Arguments(fields), new OptArgs());
            }
            public IndexDrop indexDrop (params object[] fields){
                    return new IndexDrop (this, new Arguments(fields), new OptArgs());
            }
            public IndexList indexList (params object[] fields){
                    return new IndexList (this, new Arguments(fields), new OptArgs());
            }
            public IndexStatus indexStatus (params object[] fields){
                    return new IndexStatus (this, new Arguments(fields), new OptArgs());
            }
            public IndexWait indexWait (params object[] fields){
                    return new IndexWait (this, new Arguments(fields), new OptArgs());
            }
            public IndexRename indexRename (params object[] fields){
                    return new IndexRename (this, new Arguments(fields), new OptArgs());
            }
            public GetIntersecting getIntersecting (params object[] fields){
                    return new GetIntersecting (this, new Arguments(fields), new OptArgs());
            }
            public GetNearest getNearest (params object[] fields){
                    return new GetNearest (this, new Arguments(fields), new OptArgs());
            }

    }
}
