




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

    // Tests for the basic usage of the multiplication operation

    [TestFixture]
    public class MathLogicMul : YamlTestFixture {

        public MathLogicMul (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI2IiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkgKiAyIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5tdWwoMkwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjIiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMkwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/mul.yaml, #6
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1) * 2 */
                 var obtained = runOrCatch( r.expr(1L).mul(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI3IiwiT3JpZ2luYWwiOiIxICogci5leHByKDIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5tdWwoMUwsIHIuZXhwcigyTCkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjIiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMkwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/mul.yaml, #7
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: 1 * r.expr(2) */
                 var obtained = runOrCatch( r.mul(1L, r.expr(2L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI4IiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkubXVsKDIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5tdWwoMkwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjIiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMkwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/mul.yaml, #8
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1).mul(2) */
                 var obtained = runOrCatch( r.expr(1L).mul(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiIxNSIsIk9yaWdpbmFsIjoici5leHByKC0xKSAqIC0xIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKC0xTCkubXVsKC0xTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMSIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIxTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/mul.yaml, #15
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(-1) * -1 */
                 var obtained = runOrCatch( r.expr(-1L).mul(-1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiIyMSIsIk9yaWdpbmFsIjoici5leHByKDEuNSkgKiA0LjUiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoMS41KS5tdWwoNC41KSIsIkV4cGVjdGVkT3JpZ2luYWwiOiI2Ljc1IiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiNi43NSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/mul.yaml, #21
                 /* ExpectedOriginal: 6.75 */
                 var expected_ = 6.75;
                 
                 /* Original: r.expr(1.5) * 4.5 */
                 var obtained = runOrCatch( r.expr(1.5).mul(4.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiIyNSIsIk9yaWdpbmFsIjoici5leHByKFsxLDIsM10pICogMyIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcihyLmFycmF5KDFMLCAyTCwgM0wpKS5tdWwoM0wpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlsxLDIsMywxLDIsMywxLDIsM10iLCJFeHBlY3RlZFR5cGUiOiJMaXN0IiwiRXhwZWN0ZWRKYXZhIjoici5hcnJheSgxTCwgMkwsIDNMLCAxTCwgMkwsIDNMLCAxTCwgMkwsIDNMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/mul.yaml, #25
                 /* ExpectedOriginal: [1,2,3,1,2,3,1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L, 1L, 2L, 3L, 1L, 2L, 3L);
                 
                 /* Original: r.expr([1,2,3]) * 3 */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).mul(3L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiIzMCIsIk9yaWdpbmFsIjoici5leHByKDEpLm11bCgyLDMsNCw1KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkubXVsKDJMLCAzTCwgNEwsIDVMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxMjAiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMTIwTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/mul.yaml, #30
                 /* ExpectedOriginal: 120 */
                 var expected_ = 120L;
                 
                 /* Original: r.expr(1).mul(2,3,4,5) */
                 var obtained = runOrCatch( r.expr(1L).mul(2L, 3L, 4L, 5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI0NiIsIk9yaWdpbmFsIjoici5leHByKCdhJykgKiAwLjgiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoXCJhXCIpLm11bCgwLjgpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsICdFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLicsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgdHlwZSBOVU1CRVIgYnV0IGZvdW5kIFNUUklORy5cIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/mul.yaml, #46
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('a') * 0.8 */
                 var obtained = runOrCatch( r.expr("a").mul(0.8) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI1MCIsIk9yaWdpbmFsIjoici5leHByKDEpICogJ2EnIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5tdWwoXCJhXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsICdFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLicsIFsxXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgdHlwZSBOVU1CRVIgYnV0IGZvdW5kIFNUUklORy5cIiwgci5hcnJheSgxTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/mul.yaml, #50
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(1L));
                 
                 /* Original: r.expr(1) * 'a' */
                 var obtained = runOrCatch( r.expr(1L).mul("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI1NCIsIk9yaWdpbmFsIjoici5leHByKCdiJykgKiAnYSciLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoXCJiXCIpLm11bChcImFcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKCdSZXFsUXVlcnlMb2dpY0Vycm9yJywgJ0V4cGVjdGVkIHR5cGUgTlVNQkVSIGJ1dCBmb3VuZCBTVFJJTkcuJywgWzBdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLlwiLCByLmFycmF5KDBMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/mul.yaml, #54
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('b') * 'a' */
                 var obtained = runOrCatch( r.expr("b").mul("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9tdWwueWFtbCIsIkxpbmVOdW0iOiI1OCIsIk9yaWdpbmFsIjoici5leHByKFtdKSAqIDEuNSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcihyLmFycmF5KCkpLm11bCgxLjUpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycignUmVxbFF1ZXJ5TG9naWNFcnJvcicsICdOdW1iZXIgbm90IGFuIGludGVnZXI6IDEuNScsIFswXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiTnVtYmVyIG5vdCBhbiBpbnRlZ2VyOiAxLjVcIiwgci5hcnJheSgwTCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/mul.yaml, #58
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Number not an integer: 1.5', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Number not an integer: 1.5", r.array(0L));
                 
                 /* Original: r.expr([]) * 1.5 */
                 var obtained = runOrCatch( r.expr(r.array()).mul(1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
