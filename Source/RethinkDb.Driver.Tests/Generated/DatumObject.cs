




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

    // Tests conversion to and from the RQL object type

    [TestFixture]
    public class DatumObject : YamlTestFixture {

        public DatumObject (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiNiIsIk9yaWdpbmFsIjoici5leHByKHt9KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcihyLmhhc2hNYXAoKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoie30iLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #6
                 /* ExpectedOriginal: {} */
                 var expected_ = r.hashMap();
                 
                 /* Original: r.expr({}) */
                 var obtained = runOrCatch( r.expr(r.hashMap()) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMTEiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOjF9KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcihyLmhhc2hNYXAoXCJhXCIsIDFMKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoieydhJzoxfSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcImFcIiwgMUwpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/object.yaml, #11
                 /* ExpectedOriginal: {'a':1} */
                 var expected_ = r.hashMap("a", 1L);
                 
                 /* Original: r.expr({'a':1}) */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", 1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMTYiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOjEsICdiJzondHdvJywgJ2MnOlRydWV9KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcihyLmhhc2hNYXAoXCJhXCIsIDFMKS53aXRoKFwiYlwiLCBcInR3b1wiKS53aXRoKFwiY1wiLCB0cnVlKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoieydhJzoxLCAnYic6J3R3bycsICdjJzpUcnVlfSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcImFcIiwgMUwpLndpdGgoXCJiXCIsIFwidHdvXCIpLndpdGgoXCJjXCIsIHRydWUpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/object.yaml, #16
                 /* ExpectedOriginal: {'a':1, 'b':'two', 'c':True} */
                 var expected_ = r.hashMap("a", 1L).with("b", "two").with("c", true);
                 
                 /* Original: r.expr({'a':1, 'b':'two', 'c':True}) */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", 1L).with("b", "two").with("c", true)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMjAiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOnIuZXhwcigxKX0pIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKHIuaGFzaE1hcChcImFcIiwgci5leHByKDFMKSkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6InsnYSc6MX0iLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoXCJhXCIsIDFMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #20
                 /* ExpectedOriginal: {'a':1} */
                 var expected_ = r.hashMap("a", 1L);
                 
                 /* Original: r.expr({'a':r.expr(1)}) */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", r.expr(1L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMjMiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOnsnYic6W3snYyc6Mn0sICdhJywgNF19fSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5oYXNoTWFwKFwiYVwiLCByLmhhc2hNYXAoXCJiXCIsIHIuYXJyYXkoci5oYXNoTWFwKFwiY1wiLCAyTCksIFwiYVwiLCA0TCkpKSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoieydhJzp7J2InOlt7J2MnOjJ9LCAnYScsIDRdfX0iLCJFeHBlY3RlZFR5cGUiOiJNYXAiLCJFeHBlY3RlZEphdmEiOiJyLmhhc2hNYXAoXCJhXCIsIHIuaGFzaE1hcChcImJcIiwgci5hcnJheShyLmhhc2hNYXAoXCJjXCIsIDJMKSwgXCJhXCIsIDRMKSkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/object.yaml, #23
                 /* ExpectedOriginal: {'a':{'b':[{'c':2}, 'a', 4]}} */
                 var expected_ = r.hashMap("a", r.hashMap("b", r.array(r.hashMap("c", 2L), "a", 4L)));
                 
                 /* Original: r.expr({'a':{'b':[{'c':2}, 'a', 4]}}) */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", r.hashMap("b", r.array(r.hashMap("c", 2L), "a", 4L)))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMjYiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOjF9KS50eXBlX29mKCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5oYXNoTWFwKFwiYVwiLCAxTCkpLnR5cGVPZigpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ik9CSkVDVCIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6IlwiT0JKRUNUXCIiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/object.yaml, #26
                 /* ExpectedOriginal: OBJECT */
                 var expected_ = "OBJECT";
                 
                 /* Original: r.expr({'a':1}).type_of() */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", 1L)).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMzAiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOjF9KS5jb2VyY2VfdG8oJ3N0cmluZycpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKHIuaGFzaE1hcChcImFcIiwgMUwpKS5jb2VyY2VUbyhcInN0cmluZ1wiKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7XCJhXCI6MX0iLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcIntcXFwiYVxcXCI6MX1cIiIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #30
                 /* ExpectedOriginal: {"a":1} */
                 var expected_ = "{\"a\":1}";
                 
                 /* Original: r.expr({'a':1}).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", 1L)).coerceTo("string") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMzQiLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOjF9KS5jb2VyY2VfdG8oJ29iamVjdCcpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKHIuaGFzaE1hcChcImFcIiwgMUwpKS5jb2VyY2VUbyhcIm9iamVjdFwiKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7J2EnOjF9IiwiRXhwZWN0ZWRUeXBlIjoiTWFwIiwiRXhwZWN0ZWRKYXZhIjoici5oYXNoTWFwKFwiYVwiLCAxTCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/object.yaml, #34
                 /* ExpectedOriginal: {'a':1} */
                 var expected_ = r.hashMap("a", 1L);
                 
                 /* Original: r.expr({'a':1}).coerce_to('object') */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", 1L)).coerceTo("object") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiMzciLCJPcmlnaW5hbCI6InIuZXhwcih7J2EnOjF9KS5jb2VyY2VfdG8oJ2FycmF5JykiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5oYXNoTWFwKFwiYVwiLCAxTCkpLmNvZXJjZVRvKFwiYXJyYXlcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiW1snYScsMV1dIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoci5hcnJheShcImFcIiwgMUwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #37
                 /* ExpectedOriginal: [['a',1]] */
                 var expected_ = r.array(r.array("a", 1L));
                 
                 /* Original: r.expr({'a':1}).coerce_to('array') */
                 var obtained = runOrCatch( r.expr(r.hashMap("a", 1L)).coerceTo("array") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiNjYiLCJPcmlnaW5hbCI6InIub2JqZWN0KCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLm9iamVjdF8oKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7fSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcCgpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/object.yaml, #66
                 /* ExpectedOriginal: {} */
                 var expected_ = r.hashMap();
                 
                 /* Original: r.object() */
                 var obtained = runOrCatch( r.object_() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiNjkiLCJPcmlnaW5hbCI6InIub2JqZWN0KCdhJywgMSwgJ2InLCAyKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIub2JqZWN0XyhcImFcIiwgMUwsIFwiYlwiLCAyTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoieydhJzoxLCdiJzoyfSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcImFcIiwgMUwpLndpdGgoXCJiXCIsIDJMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #69
                 /* ExpectedOriginal: {'a':1,'b':2} */
                 var expected_ = r.hashMap("a", 1L).with("b", 2L);
                 
                 /* Original: r.object('a', 1, 'b', 2) */
                 var obtained = runOrCatch( r.object_("a", 1L, "b", 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiNzIiLCJPcmlnaW5hbCI6InIub2JqZWN0KCdjJysnZCcsIDMpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5vYmplY3RfKHIuYWRkKFwiY1wiLCBcImRcIiksIDNMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJ7J2NkJzozfSIsIkV4cGVjdGVkVHlwZSI6Ik1hcCIsIkV4cGVjdGVkSmF2YSI6InIuaGFzaE1hcChcImNkXCIsIDNMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #72
                 /* ExpectedOriginal: {'cd':3} */
                 var expected_ = r.hashMap("cd", 3L);
                 
                 /* Original: r.object('c'+'d', 3) */
                 var obtained = runOrCatch( r.object_(r.add("c", "d"), 3L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiNzgiLCJPcmlnaW5hbCI6InIub2JqZWN0KDEsIDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5vYmplY3RfKDFMLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLFwiRXhwZWN0ZWQgdHlwZSBTVFJJTkcgYnV0IGZvdW5kIE5VTUJFUi5cIixbXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgdHlwZSBTVFJJTkcgYnV0IGZvdW5kIE5VTUJFUi5cIiwgci5hcnJheSgpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #78
                 /* ExpectedOriginal: err("ReqlQueryLogicError","Expected type STRING but found NUMBER.",[]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array());
                 
                 /* Original: r.object(1, 1) */
                 var obtained = runOrCatch( r.object_(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiODEiLCJPcmlnaW5hbCI6InIub2JqZWN0KCdlJywgNCwgJ2UnLCA1KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIub2JqZWN0XyhcImVcIiwgNEwsIFwiZVwiLCA1TCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLFwiRHVwbGljYXRlIGtleSBcXFwiZVxcXCIgaW4gb2JqZWN0LiAgKGdvdCA0IGFuZCA1IGFzIHZhbHVlcylcIixbXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRHVwbGljYXRlIGtleSBcXFwiZVxcXCIgaW4gb2JqZWN0LiAgKGdvdCA0IGFuZCA1IGFzIHZhbHVlcylcIiwgci5hcnJheSgpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #81
                 /* ExpectedOriginal: err("ReqlQueryLogicError","Duplicate key \"e\" in object.  (got 4 and 5 as values)",[]) */
                 var expected_ = err("ReqlQueryLogicError", "Duplicate key \"e\" in object.  (got 4 and 5 as values)", r.array());
                 
                 /* Original: r.object('e', 4, 'e', 5) */
                 var obtained = runOrCatch( r.object_("e", 4L, "e", 5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vb2JqZWN0LnlhbWwiLCJMaW5lTnVtIjoiODQiLCJPcmlnaW5hbCI6InIub2JqZWN0KCdnJywgci5kYigndGVzdCcpKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIub2JqZWN0XyhcImdcIiwgci5kYihcInRlc3RcIikpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIixcIkV4cGVjdGVkIHR5cGUgREFUVU0gYnV0IGZvdW5kIERBVEFCQVNFOlwiLFtdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIERBVFVNIGJ1dCBmb3VuZCBEQVRBQkFTRTpcIiwgci5hcnJheSgpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/object.yaml, #84
                 /* ExpectedOriginal: err("ReqlQueryLogicError","Expected type DATUM but found DATABASE:",[]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type DATUM but found DATABASE:", r.array());
                 
                 /* Original: r.object('g', r.db('test')) */
                 var obtained = runOrCatch( r.object_("g", r.db("test")) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
