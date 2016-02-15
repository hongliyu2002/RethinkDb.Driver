




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
#pragma warning disable 219 //The variable 'lower_limit' is assigned but its value is never used
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // These tests test the type of command

    [TestFixture]
    public class DatumTypeof : YamlTestFixture {

        public DatumTypeof (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vdHlwZW9mLnlhbWwiLCJMaW5lTnVtIjoiNSIsIk9yaWdpbmFsIjoici5leHByKG51bGwpLnR5cGVfb2YoKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigoUmVxbEV4cHIpIG51bGwpLnR5cGVPZigpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ik5VTEwiLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcIk5VTExcIiIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/typeof.yaml, #5
                 /* ExpectedOriginal: NULL */
                 var expected_ = "NULL";
                 
                 /* Original: r.expr(null).type_of() */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vdHlwZW9mLnlhbWwiLCJMaW5lTnVtIjoiOSIsIk9yaWdpbmFsIjoici50eXBlX29mKG51bGwpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici50eXBlT2YoKFJlcWxFeHByKSBudWxsKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJOVUxMIiwiRXhwZWN0ZWRUeXBlIjoiU3RyaW5nIiwiRXhwZWN0ZWRKYXZhIjoiXCJOVUxMXCIiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/typeof.yaml, #9
                 /* ExpectedOriginal: NULL */
                 var expected_ = "NULL";
                 
                 /* Original: r.type_of(null) */
                 var obtained = runOrCatch( r.typeOf((ReqlExpr) null) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
