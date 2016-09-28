---
title: "Extended Correctness Rules rule set for managed code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5b181f5b-6c7a-4e46-a783-360e1da427a0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extended Correctness Rules rule set for managed code
The Microsoft Extended Correctness Rules rule set maximizes the logic and framework usage errors that are reported by code analysis. Extra emphasis is placed on specific scenarios such as COM interoperability and mobile applications. You should consider including this rule set if one of these scenarios applies to your project or to find additional problems in your project.  
  
 The Microsoft Extended Correctness Rules rule set includes the rules that are in the Microsoft Basic Correctness Rules rule set. The Basic Correctness Rules include the rules that are in the Microsoft Minimum Recommended Rules rule set. For more information see [Microsoft Basic Correctness Rules Code Analysis Rule Set](../vs140/basic-correctness-rules-rule-set-for-managed-code.md) and [Microsoft Minimum Recommended Rules Code Analysis Rule Set](../vs140/managed-recommended-rules-rule-set-for-managed-code.md)  
  
 The following table describes all of the rules in the Microsoft Extended Correctness Rules rule set.  
  
|Rule|Description|  
|----------|-----------------|  
|[CA1001](../vs140/ca1001--types-that-own-disposable-fields-should-be-disposable.md)|Types that own disposable fields should be disposable|  
|[CA1009](../vs140/ca1009--declare-event-handlers-correctly.md)|Declare event handlers correctly|  
|[CA1016](../vs140/ca1016--mark-assemblies-with-assemblyversionattribute.md)|Mark assemblies with AssemblyVersionAttribute|  
|[CA1033](../vs140/ca1033--interface-methods-should-be-callable-by-child-types.md)|Interface methods should be callable by child types|  
|[CA1049](../vs140/ca1049--types-that-own-native-resources-should-be-disposable.md)|Types that own native resources should be disposable|  
|[CA1060](../vs140/ca1060--move-p-invokes-to-nativemethods-class.md)|Move P/Invokes to NativeMethods class|  
|[CA1061](../vs140/ca1061--do-not-hide-base-class-methods.md)|Do not hide base class methods|  
|[CA1063](../vs140/ca1063--implement-idisposable-correctly.md)|Implement IDisposable correctly|  
|[CA1065](../vs140/ca1065--do-not-raise-exceptions-in-unexpected-locations.md)|Do not raise exceptions in unexpected locations|  
|[CA1301](../vs140/ca1301--avoid-duplicate-accelerators.md)|Avoid duplicate accelerators|  
|[CA1400](../vs140/ca1400--p-invoke-entry-points-should-exist.md)|P/Invoke entry points should exist|  
|[CA1401](../vs140/ca1401--p-invokes-should-not-be-visible.md)|P/Invokes should not be visible|  
|[CA1403](../vs140/ca1403--auto-layout-types-should-not-be-com-visible.md)|Auto layout types should not be COM visible|  
|[CA1404](../vs140/ca1404--call-getlasterror-immediately-after-p-invoke.md)|Call GetLastError immediately after P/Invoke|  
|[CA1405](../vs140/ca1405--com-visible-type-base-types-should-be-com-visible.md)|COM visible type base types should be COM visible|  
|[CA1410](../vs140/ca1410--com-registration-methods-should-be-matched.md)|COM registration methods should be matched|  
|[CA1415](../vs140/ca1415--declare-p-invokes-correctly.md)|Declare P/Invokes correctly|  
|[CA1821](../vs140/ca1821--remove-empty-finalizers.md)|Remove empty finalizers|  
|[CA1900](../vs140/ca1900--value-type-fields-should-be-portable.md)|Value type fields should be portable|  
|[CA1901](../vs140/ca1901--p-invoke-declarations-should-be-portable.md)|P/Invoke declarations should be portable|  
|[CA2002](../vs140/ca2002--do-not-lock-on-objects-with-weak-identity.md)|Do not lock on objects with weak identity|  
|[CA2100](../vs140/ca2100--review-sql-queries-for-security-vulnerabilities.md)|Review SQL queries for security vulnerabilities|  
|[CA2101](../vs140/ca2101--specify-marshaling-for-p-invoke-string-arguments.md)|Specify marshaling for P/Invoke string arguments|  
|[CA2108](../vs140/ca2108--review-declarative-security-on-value-types.md)|Review declarative security on value types|  
|[CA2111](../vs140/ca2111--pointers-should-not-be-visible.md)|Pointers should not be visible|  
|[CA2112](../vs140/ca2112--secured-types-should-not-expose-fields.md)|Secured types should not expose fields|  
|[CA2114](../vs140/ca2114--method-security-should-be-a-superset-of-type.md)|Method security should be a superset of type|  
|[CA2116](../vs140/ca2116--aptca-methods-should-only-call-aptca-methods.md)|APTCA methods should only call APTCA methods|  
|[CA2117](../vs140/ca2117--aptca-types-should-only-extend-aptca-base-types.md)|APTCA types should only extend APTCA base types|  
|[CA2122](../vs140/ca2122--do-not-indirectly-expose-methods-with-link-demands.md)|Do not indirectly expose methods with link demands|  
|[CA2123](../vs140/ca2123--override-link-demands-should-be-identical-to-base.md)|Override link demands should be identical to base|  
|[CA2124](../vs140/ca2124--wrap-vulnerable-finally-clauses-in-outer-try.md)|Wrap vulnerable finally clauses in outer try|  
|[CA2126](../vs140/ca2126--type-link-demands-require-inheritance-demands.md)|Type link demands require inheritance demands|  
|[CA2131](../vs140/ca2131--security-critical-types-may-not-participate-in-type-equivalence.md)|Security critical types may not participate in type equivalence|  
|[CA2132](../vs140/ca2132--default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors.md)|Default constructors must be at least as critical as base type default constructors|  
|[CA2133](../vs140/ca2133--delegates-must-bind-to-methods-with-consistent-transparency.md)|Delegates must bind to methods with consistent transparency|  
|[CA2134](../vs140/ca2134--methods-must-keep-consistent-transparency-when-overriding-base-methods.md)|Methods must keep consistent transparency when overriding base methods|  
|[CA2137](../vs140/ca2137--transparent-methods-must-contain-only-verifiable-il.md)|Transparent methods must contain only verifiable IL|  
|[CA2138](../vs140/ca2138--transparent-methods-must-not-call-methods-with-the-suppressunmanagedcodesecurity-attribute.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|  
|[CA2140](../vs140/ca2140--transparent-code-must-not-reference-security-critical-items.md)|Transparent code must not reference security critical items|  
|[CA2141](../vs140/ca2141-transparent-methods-must-not-satisfy-linkdemands.md)|Transparent methods must not satisfy LinkDemands|  
|[CA2146](../vs140/ca2146--types-must-be-at-least-as-critical-as-their-base-types-and-interfaces.md)|Types must be at least as critical as their base types and interfaces|  
|[CA2147](../vs140/ca2147--transparent-methods-may-not-use-security-asserts.md)|Transparent methods may not use security asserts|  
|[CA2149](../vs140/ca2149--transparent-methods-must-not-call-into-native-code.md)|Transparent methods must not call into native code|  
|[CA2200](../vs140/ca2200--rethrow-to-preserve-stack-details.md)|Rethrow to preserve stack details|  
|[CA2202](../vs140/ca2202--do-not-dispose-objects-multiple-times.md)|Do not dispose objects multiple times|  
|[CA2207](../vs140/ca2207--initialize-value-type-static-fields-inline.md)|Initialize value type static fields inline|  
|[CA2212](../vs140/ca2212--do-not-mark-serviced-components-with-webmethod.md)|Do not mark serviced components with WebMethod|  
|[CA2213](../vs140/ca2213--disposable-fields-should-be-disposed.md)|Disposable fields should be disposed|  
|[CA2214](../vs140/ca2214--do-not-call-overridable-methods-in-constructors.md)|Do not call overridable methods in constructors|  
|[CA2216](../vs140/ca2216--disposable-types-should-declare-finalizer.md)|Disposable types should declare finalizer|  
|[CA2220](../vs140/ca2220--finalizers-should-call-base-class-finalizer.md)|Finalizers should call base class finalizer|  
|[CA2229](../vs140/ca2229--implement-serialization-constructors.md)|Implement serialization constructors|  
|[CA2231](../vs140/ca2231--overload-operator-equals-on-overriding-valuetype.equals.md)|Overload operator equals on overriding ValueType.Equals|  
|[CA2232](../vs140/ca2232--mark-windows-forms-entry-points-with-stathread.md)|Mark Windows Forms entry points with STAThread|  
|[CA2235](../vs140/ca2235--mark-all-non-serializable-fields.md)|Mark all non-serializable fields|  
|[CA2236](../vs140/ca2236--call-base-class-methods-on-iserializable-types.md)|Call base class methods on ISerializable types|  
|[CA2237](../vs140/ca2237--mark-iserializable-types-with-serializableattribute.md)|Mark ISerializable types with SerializableAttribute|  
|[CA2238](../vs140/ca2238--implement-serialization-methods-correctly.md)|Implement serialization methods correctly|  
|[CA2240](../vs140/ca2240--implement-iserializable-correctly.md)|Implement ISerializable correctly|  
|[CA2241](../vs140/ca2241--provide-correct-arguments-to-formatting-methods.md)|Provide correct arguments to formatting methods|  
|[CA2242](../vs140/ca2242--test-for-nan-correctly.md)|Test for NaN correctly|  
|[CA1008](../vs140/ca1008--enums-should-have-zero-value.md)|Enums should have zero value|  
|[CA1013](../vs140/ca1013--overload-operator-equals-on-overloading-add-and-subtract.md)|Overload operator equals on overloading add and subtract|  
|[CA1303](../vs140/ca1303--do-not-pass-literals-as-localized-parameters.md)|Do not pass literals as localized parameters|  
|[CA1308](../vs140/ca1308--normalize-strings-to-uppercase.md)|Normalize strings to uppercase|  
|[CA1806](../vs140/ca1806--do-not-ignore-method-results.md)|Do not ignore method results|  
|[CA1816](../vs140/ca1816--call-gc.suppressfinalize-correctly.md)|Call GC.SuppressFinalize correctly|  
|[CA1819](../vs140/ca1819--properties-should-not-return-arrays.md)|Properties should not return arrays|  
|[CA1820](../vs140/ca1820--test-for-empty-strings-using-string-length.md)|Test for empty strings using string length|  
|[CA1903](../vs140/ca1903--use-only-api-from-targeted-framework.md)|Use only API from targeted framework|  
|[CA2004](../vs140/ca2004--remove-calls-to-gc.keepalive.md)|Remove calls to GC.KeepAlive|  
|[CA2006](../vs140/ca2006--use-safehandle-to-encapsulate-native-resources.md)|Use SafeHandle to encapsulate native resources|  
|[CA2102](../vs140/ca2102--catch-non-clscompliant-exceptions-in-general-handlers.md)|Catch non-CLSCompliant exceptions in general handlers|  
|[CA2104](../vs140/ca2104--do-not-declare-read-only-mutable-reference-types.md)|Do not declare read only mutable reference types|  
|[CA2105](../vs140/ca2105--array-fields-should-not-be-read-only.md)|Array fields should not be read only|  
|[CA2106](../vs140/ca2106--secure-asserts.md)|Secure asserts|  
|[CA2115](../vs140/ca2115--call-gc.keepalive-when-using-native-resources.md)|Call GC.KeepAlive when using native resources|  
|[CA2119](../vs140/ca2119--seal-methods-that-satisfy-private-interfaces.md)|Seal methods that satisfy private interfaces|  
|[CA2120](../vs140/ca2120--secure-serialization-constructors.md)|Secure serialization constructors|  
|[CA2121](../vs140/ca2121--static-constructors-should-be-private.md)|Static constructors should be private|  
|[CA2130](../vs140/ca2130--security-critical-constants-should-be-transparent.md)|Security critical constants should be transparent|  
|[CA2205](../vs140/ca2205--use-managed-equivalents-of-win32-api.md)|Use managed equivalents of Win32 API|  
|[CA2215](../vs140/ca2215--dispose-methods-should-call-base-class-dispose.md)|Dispose methods should call base class dispose|  
|[CA2221](../vs140/ca2221--finalizers-should-be-protected.md)|Finalizers should be protected|  
|[CA2222](../vs140/ca2222--do-not-decrease-inherited-member-visibility.md)|Do not decrease inherited member visibility|  
|[CA2223](../vs140/ca2223--members-should-differ-by-more-than-return-type.md)|Members should differ by more than return type|  
|[CA2224](../vs140/ca2224--override-equals-on-overloading-operator-equals.md)|Override equals on overloading operator equals|  
|[CA2226](../vs140/ca2226--operators-should-have-symmetrical-overloads.md)|Operators should have symmetrical overloads|  
|[CA2227](../vs140/ca2227--collection-properties-should-be-read-only.md)|Collection properties should be read only|  
|[CA2239](../vs140/ca2239--provide-deserialization-methods-for-optional-fields.md)|Provide deserialization methods for optional fields|  
|[CA1032](../vs140/ca1032--implement-standard-exception-constructors.md)|Implement standard exception constructors|  
|[CA1054](../vs140/ca1054--uri-parameters-should-not-be-strings.md)|URI parameters should not be strings|  
|[CA1055](../vs140/ca1055--uri-return-values-should-not-be-strings.md)|URI return values should not be strings|  
|[CA1056](../vs140/ca1056--uri-properties-should-not-be-strings.md)|URI properties should not be strings|  
|[CA1057](../vs140/ca1057--string-uri-overloads-call-system.uri-overloads.md)|String URI overloads call System.Uri overloads|  
|[CA1402](../vs140/ca1402--avoid-overloads-in-com-visible-interfaces.md)|Avoid overloads in COM visible interfaces|  
|[CA1406](../vs140/ca1406--avoid-int64-arguments-for-visual-basic-6-clients.md)|Avoid Int64 arguments for Visual Basic 6 clients|  
|[CA1407](../vs140/ca1407--avoid-static-members-in-com-visible-types.md)|Avoid static members in COM visible types|  
|[CA1408](../vs140/ca1408--do-not-use-autodual-classinterfacetype.md)|Do not use AutoDual ClassInterfaceType|  
|[CA1409](../vs140/ca1409--com-visible-types-should-be-creatable.md)|Com visible types should be creatable|  
|[CA1411](../vs140/ca1411--com-registration-methods-should-not-be-visible.md)|COM registration methods should not be visible|  
|[CA1412](../vs140/ca1412--mark-comsource-interfaces-as-idispatch.md)|Mark ComSource Interfaces as IDispatch|  
|[CA1413](../vs140/ca1413--avoid-non-public-fields-in-com-visible-value-types.md)|Avoid non-public fields in COM visible value types|  
|[CA1414](../vs140/ca1414--mark-boolean-p-invoke-arguments-with-marshalas.md)|Mark boolean P/Invoke arguments with MarshalAs|  
|[CA1600](../vs140/ca1600--do-not-use-idle-process-priority.md)|Do not use idle process priority|  
|[CA1601](../vs140/ca1601--do-not-use-timers-that-prevent-power-state-changes.md)|Do not use timers that prevent power state changes|  
|[CA1824](../vs140/ca1824--mark-assemblies-with-neutralresourceslanguageattribute.md)|Mark assemblies with NeutralResourcesLanguageAttribute|  
|[CA2001](../vs140/ca2001--avoid-calling-problematic-methods.md)|Avoid calling problematic methods|  
|[CA2003](../vs140/ca2003--do-not-treat-fibers-as-threads.md)|Do not treat fibers as threads|  
|[CA2135](../vs140/ca2135--level-2-assemblies-should-not-contain-linkdemands.md)|Level 2 assemblies should not contain LinkDemands|  
|[CA2136](../vs140/ca2136--members-should-not-have-conflicting-transparency-annotations.md)|Members should not have conflicting transparency annotations|  
|[CA2139](../vs140/ca2139--transparent-methods-may-not-use-the-handleprocesscorruptingexceptions-attribute.md)|Transparent methods may not use the HandleProcessCorruptingExceptions attribute|  
|[CA2142](../vs140/ca2142--transparent-code-should-not-be-protected-with-linkdemands.md)|Transparent code should not be protected with LinkDemands|  
|[CA2143](../vs140/ca2143--transparent-methods-should-not-use-security-demands.md)|Transparent methods should not use security demands|  
|[CA2144](../vs140/ca2144--transparent-code-should-not-load-assemblies-from-byte-arrays.md)|Transparent code should not load assemblies from byte arrays|  
|[CA2145](../vs140/ca2145--transparent-methods-should-not-be-decorated-with-the-suppressunmanagedcodesecurityattribute.md)|Transparent methods should not be decorated with the SuppressUnmanagedCodeSecurityAttribute|  
|[CA2204](../vs140/ca2204--literals-should-be-spelled-correctly.md)|Literals should be spelled correctly|  
|[CA2211](../vs140/ca2211--non-constant-fields-should-not-be-visible.md)|Non-constant fields should not be visible|  
|[CA2217](../vs140/ca2217--do-not-mark-enums-with-flagsattribute.md)|Do not mark enums with FlagsAttribute|  
|[CA2218](../vs140/ca2218--override-gethashcode-on-overriding-equals.md)|Override GetHashCode on overriding Equals|  
|[CA2219](../vs140/ca2219--do-not-raise-exceptions-in-exception-clauses.md)|Do not raise exceptions in exception clauses|  
|[CA2225](../vs140/ca2225--operator-overloads-have-named-alternates.md)|Operator overloads have named alternates|  
|[CA2228](../vs140/ca2228--do-not-ship-unreleased-resource-formats.md)|Do not ship unreleased resource formats|  
|[CA2230](../vs140/ca2230--use-params-for-variable-arguments.md)|Use params for variable arguments|  
|[CA2233](../vs140/ca2233--operations-should-not-overflow.md)|Operations should not overflow|  
|[CA2234](../vs140/ca2234--pass-system.uri-objects-instead-of-strings.md)|Pass System.Uri objects instead of strings|  
|[CA2243](../vs140/ca2243--attribute-string-literals-should-parse-correctly.md)|Attribute string literals should parse correctly|