




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

    // Tests for basic usage of the subtraction operation

    [TestFixture]
    public class MathLogicSub : YamlTestFixture {

        public MathLogicSub (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiI2IiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkgLSAxIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5zdWIoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjAiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMEwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/sub.yaml, #6
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: r.expr(1) - 1 */
                 var obtained = runOrCatch( r.expr(1L).sub(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiI3IiwiT3JpZ2luYWwiOiIxIC0gci5leHByKDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5zdWIoMUwsIHIuZXhwcigxTCkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjAiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMEwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/sub.yaml, #7
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: 1 - r.expr(1) */
                 var obtained = runOrCatch( r.sub(1L, r.expr(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiI4IiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkuc3ViKDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5zdWIoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjAiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMEwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/sub.yaml, #8
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: r.expr(1).sub(1) */
                 var obtained = runOrCatch( r.expr(1L).sub(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiIxNyIsIk9yaWdpbmFsIjoici5leHByKC0xKSAtIDEiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoLTFMKS5zdWIoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ii0yIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6Ii0yTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/sub.yaml, #17
                 /* ExpectedOriginal: -2 */
                 var expected_ = -2L;
                 
                 /* Original: r.expr(-1) - 1 */
                 var obtained = runOrCatch( r.expr(-1L).sub(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiIyMiIsIk9yaWdpbmFsIjoici5leHByKDEuNzUpIC0gOC41IiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDEuNzUpLnN1Yig4LjUpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ii02Ljc1IiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiLTYuNzUiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/sub.yaml, #22
                 /* ExpectedOriginal: -6.75 */
                 var expected_ = -6.75;
                 
                 /* Original: r.expr(1.75) - 8.5 */
                 var obtained = runOrCatch( r.expr(1.75).sub(8.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiIyNiIsIk9yaWdpbmFsIjoici5leHByKDEpLnN1YigyLDMsNCw1KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuc3ViKDJMLCAzTCwgNEwsIDVMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiItMTMiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiLTEzTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/sub.yaml, #26
                 /* ExpectedOriginal: -13 */
                 var expected_ = -13L;
                 
                 /* Original: r.expr(1).sub(2,3,4,5) */
                 var obtained = runOrCatch( r.expr(1L).sub(2L, 3L, 4L, 5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiIzMCIsIk9yaWdpbmFsIjoici5leHByKCdhJykuc3ViKDAuOCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoXCJhXCIpLnN1YigwLjgpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsICdFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgdHlwZSBOVU1CRVIgYnV0IGZvdW5kIFNUUklORy5cIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/sub.yaml, #30
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('a').sub(0.8) */
                 var obtained = runOrCatch( r.expr("a").sub(0.8) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiIzMyIsIk9yaWdpbmFsIjoici5leHByKDEpLnN1YignYScpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5zdWIoXCJhXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsICdFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLicsIFsxXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgdHlwZSBOVU1CRVIgYnV0IGZvdW5kIFNUUklORy5cIiwgci5hcnJheSgxTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/sub.yaml, #33
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(1L));
                 
                 /* Original: r.expr(1).sub('a') */
                 var obtained = runOrCatch( r.expr(1L).sub("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9zdWIueWFtbCIsIkxpbmVOdW0iOiIzNiIsIk9yaWdpbmFsIjoici5leHByKCdiJykuc3ViKCdhJykiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoXCJiXCIpLnN1YihcImFcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHR5cGUgTlVNQkVSIGJ1dCBmb3VuZCBTVFJJTkcuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/sub.yaml, #36
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('b').sub('a') */
                 var obtained = runOrCatch( r.expr("b").sub("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
