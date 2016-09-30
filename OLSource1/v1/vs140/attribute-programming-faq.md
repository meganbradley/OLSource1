---
title: "Attribute Programming FAQ"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "attributed programming"
  - "attributes [C++], frequently asked questions"
  - "FAQs (frequently asked questions), attributed programming [C++]"
ms.assetid: a1b8349f-7f51-43c4-95ea-4edb6e5f243f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute Programming FAQ
This topic answers the following frequently asked questions:  
  
-   [What is an HRESULT?](#vcconattributeprogrammmingfaqanchor1)  
  
-   [When do I have to specify the parameter name for an attribute?](#vcconattributeprogrammmingfaqanchor2)  
  
-   [Can I use comments in an attribute block?](#vcconattributeprogrammmingfaqanchor3)  
  
-   [How do attributes interact with inheritance?](#vcconattributeprogrammmingfaqanchor4)  
  
-   [How can I use attributes in a nonattributed ATL project?](#vcconattributeprogrammmingfaqanchor5)  
  
-   [How can I use an .idl file in an attributed project?](#vcconattributeprogrammmingfaqanchor6)  
  
-   [Can I modify code that is injected by an attribute?](#vcconattributeprogrammmingfaqanchor7)  
  
-   [How can I forward declare an attributed interface?](#vcconattributeprogrammmingfaqhowcaniforwarddeclareanattributedinterface)  
  
-   [Can I use attributes on a class derived from a class that also uses attributes?](#vcconcaniuseattributesonclassderivedfromclassthatalsousesattributesanchor)  
  
##  \<a name="vcconattributeprogrammmingfaqanchor1">\</a> What is an HRESULT?  
 An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a simple data type that is often used as a return value by attributes and ATL in general. The following table describes the various values. More values are contained in the header file winerror.h.  
  
|Name|Description|Value|  
|----------|-----------------|-----------|  
|S_OK|Operation successful|0x00000000|  
|E_UNEXPECTED|Unexpected failure|0x8000FFFF|  
|E_NOTIMPL|Not implemented|0x80004001|  
|E_OUTOFMEMORY|Failed to allocate necessary memory|0x8007000E|  
|E_INVALIDARG|One or more arguments are invalid|0x80070057|  
|E_NOINTERFACE|No such interface supported|0x80004002|  
|E_POINTER|Invalid pointer|0x80004003|  
|E_HANDLE|Invalid handle|0x80070006|  
|E_ABORT|Operation aborted|0x80004004|  
|E_FAIL|Unspecified failure|0x80004005|  
|E_ACCESSDENIED|General access denied error|0x80070005|  
  
##  \<a name="vcconattributeprogrammmingfaqanchor2">\</a> When do I have to specify the parameter name for an attribute?  
 In most cases, if the attribute has a single parameter, that parameter is named. This name is not required when inserting the attribute in your code. For example, the following usage of the [aggregatable](../vs140/aggregatable.md) attribute:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 is exactly the same as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, the following attributes have single, unnamed parameters:  
  
||||  
|-|-|-|  
|[call_as](../vs140/call_as.md)|[case](../vs140/case--c---.md)|[cpp_quote](../vs140/cpp_quote.md)|  
|[default](../vs140/default--c---.md)|[defaultvalue](../vs140/defaultvalue.md)|[defaultvtable](../vs140/defaultvtable.md)|  
|[emitidl](../vs140/emitidl.md)|[entry](../vs140/entry.md)|[first_is](../vs140/first_is.md)|  
|[helpcontext](../vs140/helpcontext.md)|[helpfile](../vs140/helpfile.md)|[helpstring](../vs140/helpstring.md)|  
|[helpstringcontext](../vs140/helpstringcontext.md)|[helpstringdll](../vs140/helpstringdll.md)|[id](../vs140/id.md)|  
|[iid_is](../vs140/iid_is.md)|[import](../vs140/import.md)|[importlib](../vs140/importlib.md)|  
|[include](../vs140/include--c---.md)|[includelib](../vs140/includelib--c---.md)|[last_is](../vs140/last_is.md)|  
|[length_is](../vs140/length_is.md)|[max_is](../vs140/max_is.md)|[no_injected_text](../vs140/no_injected_text.md)|  
|[pointer_default](../vs140/pointer_default.md)|[pragma](../vs140/pragma.md)|[restricted](../vs140/restricted.md)|  
|[size_is](../vs140/size_is.md)|[source](../vs140/source--c---.md)|[switch_is](../vs140/switch_is.md)|  
|[switch_type](../vs140/switch_type.md)|[transmit_as](../vs140/transmit_as.md)|[wire_marshal](../vs140/wire_marshal.md)|  
  
##  \<a name="vcconattributeprogrammmingfaqanchor3">\</a> Can I use comments in an attribute block?  
 You can use both single-line and multiple-line comments within an attribute block. However, you cannot use either style of comment within the parentheses holding the parameters to an attribute.  
  
 The following is allowed:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following is disallowed:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="vcconattributeprogrammmingfaqanchor4">\</a> How do attributes interact with inheritance?  
 You can inherit both attributed and unattributed classes from other classes, which may themselves be attributed or not. The result of deriving from an attributed class is the same as deriving from that class after the attribute provider has transformed its code. Attributes are not transmitted to derived classes through C++ inheritance. An attribute provider only transforms code in the vicinity of its attributes.  
  
##  \<a name="vcconattributeprogrammmingfaqanchor5">\</a> How can I use attributes in a nonattributed ATL project?  
 You may have a nonattributed ATL project, which has an .idl file, and you may want to start adding attributed objects. In this case, use the Add Class Wizard to provide the code.  
  
##  \<a name="vcconattributeprogrammmingfaqanchor6">\</a> How can I use an .idl file in an attributed project?  
 You may have a .idl file that you want to use in your ATL attributed project. In this case, you would use the [importidl](../vs140/importidl.md) attribute, compile the .idl file to a .h file (see the [MIDL Property Pages](../vs140/midl-property-pages.md) in the project's Property Pages dialog box), and then include the .h file in your project.  
  
##  \<a name="vcconattributeprogrammmingfaqanchor7">\</a> Can I modify code that is injected by an attribute?  
 Some attributes inject code into your project. You can see the injected code by using the [/Fx](../vs140/-fx--merge-injected-code-.md) compiler option. It is also possible to copy code from the injected file and paste it into your source code. This allows you to modify the behavior of the attribute. However, you may have to modify other parts of your code as well.  
  
 The following sample is the result of copying injected code into a source code file:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="vcconattributeprogrammmingfaqhowcaniforwarddeclareanattributedinterface">\</a> How can I forward declare an attributed interface?  
 If you are going to make a forward declaration of an attributed interface, you must apply the same attributes to the forward declaration that you apply to the actual interface declaration. You must also apply the [export](../vs140/export.md) attribute to your forward declaration.  
  
##  \<a name="vcconcaniuseattributesonclassderivedfromclassthatalsousesattributesanchor">\</a> Can I use attributes on a class derived from a class that also uses attributes?  
 No, using attributes on a class derived from a class that also uses attributes is not supported.  
  
## See Also  
 [Concepts](../vs140/attributed-programming-concepts.md)