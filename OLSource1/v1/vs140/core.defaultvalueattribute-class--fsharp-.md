---
title: "Core.DefaultValueAttribute Class (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Core.DefaultValueAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.DefaultValueAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "DefaultValueAttribute class [F#]"
  - "DefaultValue attribute [F#]"
ms.assetid: a3a3307b-8c05-441e-b109-245511614d58
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.DefaultValueAttribute Class (F#)
Adding this attribute to a field declaration means that the field is not initialized. During type checking a constraint is asserted that the field type supports <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. If the [Check](../vs140/defaultvalueattribute.check-property--fsharp-.md) value is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> then the constraint is not asserted.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This attribute is intended to be used on explicit fields in classes and structures. It shouldn't be used on records. For more information, see [Records (F#)](../vs140/records--fsharp-.md) and [Explicit Fields: The val Keyword (F#)](../vs140/explicit-fields--the-val-keyword--fsharp-.md).  
  
 The .NET Framework namespace \<xref:System.ComponentModel*> defines an attribute that has the same name:  \<xref:System.ComponentModel.DefaultValueAttribute*>. Therefore, you must fully qualify the F# attribute if you open the \<xref:System.ComponentModel*> namespace.  
  
 You can also use the short form of the name, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.defaultvalueattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Check](../vs140/defaultvalueattribute.check-property--fsharp-.md)|Indicates if a constraint is asserted that the field type supports 'null'|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)