---
title: "Caller Information (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 15d556eb-4d0c-4497-98a3-7f60abb7d6a1
caps.latest.revision: 7
---
# Caller Information (Visual Basic)
By using Caller Info attributes, you can obtain information about the caller to a method. You can obtain file path of the source code, the line number in the source code, and the member name of the caller. This information is helpful for tracing, debugging, and creating diagnostic tools.  
  
 To obtain this information, you use attributes that are applied to optional parameters, each of which has a default value. The following table lists the Caller Info attributes that are defined in the \<xref:System.Runtime.CompilerServices*?displayProperty=fullName> namespace:  
  
||||  
|-|-|-|  
|Attribute|Description|Type|  
|\<xref:System.Runtime.CompilerServices.CallerFilePathAttribute*>|Full path of the source file that contains the caller. This is the file path at compile time.|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|\<xref:System.Runtime.CompilerServices.CallerLineNumberAttribute*>|Line number in the source file at which the method is called.|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|\<xref:System.Runtime.CompilerServices.CallerMemberNameAttribute*>|Method or property name of the caller. See [Member Names](#MEMBERNAMES) later in this topic.|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
  
## Example  
 The following example shows how to use Caller Info attributes. On each call to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method, the caller information is substituted as arguments to the optional parameters.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You must specify an explicit default value for each optional parameter. You can't apply Caller Info attributes to parameters that aren't specified as optional.  
  
 The Caller Info attributes don't make a parameter optional. Instead, they affect the default value that's passed in when the argument is omitted.  
  
 Caller Info values are emitted as literals into the Intermediate Language (IL) at compile time. Unlike the results of the \<xref:System.Exception.StackTrace*> property for exceptions, the results aren't affected by obfuscation.  
  
 You can explicitly supply the optional arguments to control the caller information or to hide caller information.  
  
###  \<a name="MEMBERNAMES">\</a> Member Names  
 You can use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute to avoid specifying the member name as a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument to the called method. By using this technique, you avoid the problem that **Rename Refactoring** doesn't change the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values. This benefit is especially useful for the following tasks:  
  
-   Using tracing and diagnostic routines.  
  
-   Implementing the \<xref:System.ComponentModel.INotifyPropertyChanged*> interface when binding data. This interface allows the property of an object to notify a bound control that the property has changed, so that the control can display the updated information. Without the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute, you must specify the property name as a literal.  
  
 The following chart shows the member names that are returned when you use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute.  
  
|Calls occurs within|Member name result|  
|-------------------------|------------------------|  
|Method, property, or event|The name of the method, property, or event from which the call originated.|  
|Constructor|The string ".ctor"|  
|Static constructor|The string ".cctor"|  
|Destructor|The string "Finalize"|  
|User-defined operators or conversions|The generated name for the member, for example, "op_Addition".|  
|Attribute constructor|The name of the member to which the attribute is applied. If the attribute is any element within a member (such as a parameter, a return value, or a generic type parameter), this result is the name of the member that's associated with that element.|  
|No containing member (for example, assembly-level or attributes that are applied to types)|The default value of the optional parameter.|  
  
## See Also  
 [Attributes (Visual Basic)](../vs140/attributes--visual-basic-1.md)   
 [Common Attributes (Visual Basic)](../vs140/common-attributes--visual-basic-.md)   
 [Optional Parameters (Visual Basic)](../vs140/optional-parameters--visual-basic-.md)   
 [Programming Concepts (Visual Basic)](../vs140/programming-concepts--visual-basic-.md)