---
title: "TYPE_INFO"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "TYPE_INFO"
helpviewer_keywords: 
  - "TYPE_INFO structure"
ms.assetid: d725cb68-a565-49d1-a16f-ff0445c587a0
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# TYPE_INFO
This structure specifies various kinds of information about a field's type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 dwKind  
 A value from the [dwTYPE_KIND](../vs140/dwtype_kind.md) enumeration that determines how to interpret the union.  
  
 type.typeMeta  
 [C++ only] Contains a [METADATA_TYPE](../vs140/metadata_type.md) structure if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 type.typePdb  
 [C++ only] Contains a [PDB_TYPE](../vs140/pdb_type.md) structure if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 type.typeBuilt  
 [C++ only] Contains a [BUILT_TYPE](../vs140/built_type.md) structure if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 type.unused  
 Unused padding.  
  
 type  
 Name of the union.  
  
 unionmember  
 [C# only] Marshal this to the appropriate structure type based on <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 This structure is passed to the [IDebugField::GetTypeInfo](../vs140/idebugfield--gettypeinfo.md) method where it is filled in. How the contents of the structure are interpreted is based on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field.  
  
> [!NOTE]
>  [C++ only] If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, then it is necessary to release the underlying [IDebugField](../vs140/idebugfield.md) object when destroying the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure. This is done by calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 [C# only] The following table shows how to interpret the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member for each kind of type. The Example shows how this is done for one kind of type.  
  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interpreted as|  
|--------------|----------------------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|[METADATA_TYPE](../vs140/metadata_type.md)|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|[PDB_TYPE](../vs140/pdb_type.md)|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[BUILT_TYPE](../vs140/built_type.md)|  
  
## Example  
 This example shows how to interpret the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> structure in C#. This example shows interpreting only one type (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) but the others are interpreted in exactly the same way.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [dwTYPE_KIND](../vs140/dwtype_kind.md)   
 [IDebugField::GetTypeInfo](../vs140/idebugfield--gettypeinfo.md)   
 [METADATA_TYPE](../vs140/metadata_type.md)   
 [PDB_TYPE](../vs140/pdb_type.md)   
 [BUILT_TYPE](../vs140/built_type.md)