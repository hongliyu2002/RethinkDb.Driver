




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

    // Test named aliases for math and logic operators

    [TestFixture]
    public class MathLogicAliases : YamlTestFixture {

        public MathLogicAliases (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNSIsIk9yaWdpbmFsIjoici5leHByKDApLmFkZCgxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigwTCkuYWRkKDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #5
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(0).add(1) */
                 var obtained = runOrCatch( r.expr(0L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNiIsIk9yaWdpbmFsIjoici5hZGQoMCwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmFkZCgwTCwgMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjEiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMUwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/aliases.yaml, #6
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.add(0, 1) */
                 var obtained = runOrCatch( r.add(0L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNyIsIk9yaWdpbmFsIjoici5leHByKDIpLnN1YigxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigyTCkuc3ViKDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #7
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(2).sub(1) */
                 var obtained = runOrCatch( r.expr(2L).sub(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiOCIsIk9yaWdpbmFsIjoici5zdWIoMiwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnN1YigyTCwgMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjEiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMUwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/aliases.yaml, #8
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.sub(2, 1) */
                 var obtained = runOrCatch( r.sub(2L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiOSIsIk9yaWdpbmFsIjoici5leHByKDIpLmRpdigyKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigyTCkuZGl2KDJMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #9
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(2).div(2) */
                 var obtained = runOrCatch( r.expr(2L).div(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMTAiLCJPcmlnaW5hbCI6InIuZGl2KDIsIDIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5kaXYoMkwsIDJMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #10
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.div(2, 2) */
                 var obtained = runOrCatch( r.div(2L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMTEiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5tdWwoMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoMUwpLm11bCgxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMSIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIxTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #11
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1).mul(1) */
                 var obtained = runOrCatch( r.expr(1L).mul(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMTIiLCJPcmlnaW5hbCI6InIubXVsKDEsIDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5tdWwoMUwsIDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #12
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.mul(1, 1) */
                 var obtained = runOrCatch( r.mul(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMTMiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5tb2QoMikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoMUwpLm1vZCgyTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMSIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIxTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #13
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1).mod(2) */
                 var obtained = runOrCatch( r.expr(1L).mod(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMTQiLCJPcmlnaW5hbCI6InIubW9kKDEsIDIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5tb2QoMUwsIDJMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #14
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.mod(1, 2) */
                 var obtained = runOrCatch( r.mod(1L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMjUiLCJPcmlnaW5hbCI6InIuZXhwcihUcnVlKS5hbmRfKFRydWUpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKHRydWUpLmFuZCh0cnVlKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJUcnVlIiwiRXhwZWN0ZWRUeXBlIjoiYm9vbCIsIkV4cGVjdGVkSmF2YSI6InRydWUiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/aliases.yaml, #25
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(True).and_(True) */
                 var obtained = runOrCatch( r.expr(true).and(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMjYiLCJPcmlnaW5hbCI6InIuZXhwcihUcnVlKS5vcl8oVHJ1ZSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIodHJ1ZSkub3IodHJ1ZSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #26
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(True).or_(True) */
                 var obtained = runOrCatch( r.expr(true).or(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMjciLCJPcmlnaW5hbCI6InIuYW5kXyhUcnVlLCBUcnVlKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuYW5kKHRydWUsIHRydWUpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #27
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.and_(True, True) */
                 var obtained = runOrCatch( r.and(true, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMjgiLCJPcmlnaW5hbCI6InIub3JfKFRydWUsIFRydWUpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5vcih0cnVlLCB0cnVlKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJUcnVlIiwiRXhwZWN0ZWRUeXBlIjoiYm9vbCIsIkV4cGVjdGVkSmF2YSI6InRydWUiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/aliases.yaml, #28
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.or_(True, True) */
                 var obtained = runOrCatch( r.or(true, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMjkiLCJPcmlnaW5hbCI6InIuZXhwcihGYWxzZSkubm90XygpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKGZhbHNlKS5ub3QoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJUcnVlIiwiRXhwZWN0ZWRUeXBlIjoiYm9vbCIsIkV4cGVjdGVkSmF2YSI6InRydWUiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/aliases.yaml, #29
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(False).not_() */
                 var obtained = runOrCatch( r.expr(false).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzAiLCJPcmlnaW5hbCI6InIubm90XyhGYWxzZSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLm5vdChmYWxzZSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #30
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.not_(False) */
                 var obtained = runOrCatch( r.not(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzQiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5lcSgxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuZXEoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #34
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).eq(1) */
                 var obtained = runOrCatch( r.expr(1L).eq(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzUiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5uZSgyKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkubmUoMkwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #35
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).ne(2) */
                 var obtained = runOrCatch( r.expr(1L).ne(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzYiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5sdCgyKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkubHQoMkwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #36
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).lt(2) */
                 var obtained = runOrCatch( r.expr(1L).lt(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzciLCJPcmlnaW5hbCI6InIuZXhwcigxKS5ndCgwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuZ3QoMEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #37
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).gt(0) */
                 var obtained = runOrCatch( r.expr(1L).gt(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzgiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5sZSgxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkubGUoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #38
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).le(1) */
                 var obtained = runOrCatch( r.expr(1L).le(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiMzkiLCJPcmlnaW5hbCI6InIuZXhwcigxKS5nZSgxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuZ2UoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlRydWUiLCJFeHBlY3RlZFR5cGUiOiJib29sIiwiRXhwZWN0ZWRKYXZhIjoidHJ1ZSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/aliases.yaml, #39
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.expr(1).ge(1) */
                 var obtained = runOrCatch( r.expr(1L).ge(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNDAiLCJPcmlnaW5hbCI6InIuZXEoMSwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmVxKDFMLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #40
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.eq(1, 1) */
                 var obtained = runOrCatch( r.eq(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNDEiLCJPcmlnaW5hbCI6InIubmUoMSwgMikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLm5lKDFMLCAyTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #41
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.ne(1, 2) */
                 var obtained = runOrCatch( r.ne(1L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNDIiLCJPcmlnaW5hbCI6InIubHQoMSwgMikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmx0KDFMLCAyTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #42
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.lt(1, 2) */
                 var obtained = runOrCatch( r.lt(1L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNDMiLCJPcmlnaW5hbCI6InIuZ3QoMSwgMCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmd0KDFMLCAwTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #43
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.gt(1, 0) */
                 var obtained = runOrCatch( r.gt(1L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNDQiLCJPcmlnaW5hbCI6InIubGUoMSwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmxlKDFMLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #44
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.le(1, 1) */
                 var obtained = runOrCatch( r.le(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hbGlhc2VzLnlhbWwiLCJMaW5lTnVtIjoiNDUiLCJPcmlnaW5hbCI6InIuZ2UoMSwgMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmdlKDFMLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiVHJ1ZSIsIkV4cGVjdGVkVHlwZSI6ImJvb2wiLCJFeHBlY3RlZEphdmEiOiJ0cnVlIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/aliases.yaml, #45
                 /* ExpectedOriginal: True */
                 var expected_ = true;
                 
                 /* Original: r.ge(1, 1) */
                 var obtained = runOrCatch( r.ge(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
