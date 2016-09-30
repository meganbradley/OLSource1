---
title: "idl_module"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "vc-attr.idl_module"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "idl_module attribute"
ms.assetid: 3578b337-e38a-4334-b747-15404c02dbc0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# idl_module
Specifies an entry point in a .dll file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **name**  
 A user-defined name for the code block that will appear in the .idl file.  
  
 **dllname** (optional)  
 The .dll file that contains the export.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (optional)  
 A unique ID.  
  
 **helpstring** (optional)  
 A character string used to describe the type library.  
  
 **helpstringcontext** (optional)  
 The ID of a help topic in an .hlp or .chm file.  
  
 **helpcontext** (optional)  
 The Help ID for this type library.  
  
 **hidden** (optional)  
 A parameter that prevents the library from being displayed. See the [hidden](http://msdn.microsoft.com/library/windows/desktop/aa366861) MIDL attribute for more information.  
  
 ***restricted***  (optional)  
 Members of the library cannot be arbitrarily called. See the [restricted](http://msdn.microsoft.com/library/windows/desktop/aa367157) MIDL attribute for more information.  
  
 *function declaration*  
 The function that you will define.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> C++ attribute lets you specify the entry point in a .dll file, which allows you to import from a .dll file.  
  
 The **idl_module** attribute has functionality similar to the [module](http://msdn.microsoft.com/library/windows/desktop/aa367099) MIDL attribute.  
  
 You can export anything from a COM object that you can export from a .dll file by putting a DLL entry point in the library block of an .idl file.  
  
 Your must use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in two steps. First, you must define a name/DLL pair. Then, when you use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to specify an entry point, specify the name and any additional attributes.  
  
## Example  
 The following code shows how to use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Anywhere|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Stand-Alone Attributes](../vs140/stand-alone-attributes.md)   
 [entry](../vs140/entry.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)