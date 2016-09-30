---
title: "module (C++)"
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
  - "vc-attr.module"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "module attributes"
ms.assetid: 02223b2a-62b5-4262-832f-564b1e11e58e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# module (C++)
Defines the library block in the .idl file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 ***type***  (optional)  
 Can be one of the following:  
  
-   **dll** Adds functions and classes that allow the resulting DLL to function as a in-process COM server. This is the default value.  
  
-   **exe** Adds functions and classes that allow the resulting executable to function as a out of process COM server.  
  
-   **service** Adds functions and classes that allow the resulting executable to function as an NT service.  
  
-   **unspecified** Disables injection of ATL code related to the module attribute: the injection of ATL Module class, global instance _AtlModule and entry point functions.  Does not disable injection of ATL code due to other attributes in the project.  
  
 ***name***  (optional)  
 The name of the library block.  
  
 ***version***  (optional)  
 The version number you want to assign to the library block. The default value is 1.0.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The unique ID for the library. If you omit this parameter, an ID will be automatically generated for the library. You may need to retrieve the *uuid* of your library block, which you can do by using the identifier **__uuidof(***libraryname***)**.  
  
 **lcid**  
 The localization parameter. See [lcid](http://msdn.microsoft.com/library/windows/desktop/aa367067) for more information.  
  
 **control** (optional)  
 Specifies that all coclasses in the library are controls.  
  
 **helpstring**  
 Specifies the type library.  
  
 ***helpstringdll***  (optional)  
 Sets the name of the .dll file to use to perform a document string lookup. See [helpstringdll](http://msdn.microsoft.com/library/windows/desktop/aa366860) for more information.  
  
 **helpfile** (optional)  
 The name of the Help file for the type library.  
  
 **helpcontext** (optional)  
 The Help ID for this type library.  
  
 **helpstringcontext** (optional)  
 See [helpstringcontext](../vs140/helpstringcontext.md) for more information.  
  
 **hidden** (optional)  
 Prevents the entire library from being displayed. This usage is intended for use with controls. Hosts need to create a new type library that wraps the control with extended properties. See the [hidden](http://msdn.microsoft.com/library/windows/desktop/aa366861) MIDL attribute for more information.  
  
 **restricted** (optional)  
 Members of the library cannot be called arbitrarily. See the [restricted](http://msdn.microsoft.com/library/windows/desktop/aa367157) MIDL attribute for more information.  
  
 ***custom***  (optional)  
 One or more attributes; this is similar to the [custom](../vs140/custom--c---.md) attribute. The first parameter to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the GUID of the attribute. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **resource_name**  
 The string resource ID of the .rgs file used to register the APP ID of the DLL, executable, or service. When the module is of type service, this argument is also used to obtain the ID of the string containing the service name.  
  
> [!NOTE]
>  Both the .rgs file and the string containing the service name should contain the same numerical value.  
  
## Remarks  
 Unless you specify the **restricted** parameter to [emitidl](../vs140/emitidl.md), **module** is required in any program that uses C++ attributes.  
  
 A library block will be created if, in addition to the **module** attribute, source code also uses [dispinterface](../vs140/dispinterface.md), [dual](../vs140/dual.md), [object](../vs140/object--c---.md), or an attribute that implies [coclass](../vs140/coclass.md).  
  
 One library block is allowed in an .idl file. Multiple module entries in source code will be merged, with the most recent parameter values being implemented.  
  
 If this attribute is used within a project that uses ATL, the behavior of the attribute changes. In addition to the above behavior, the attribute also inserts a global object (called **_AtlModule**) of the correct type and additional support code. If the attribute is standalone, it inserts a class derived from the correct module type. If the attribute is applied to a class, it adds a base class of the correct module type. The correct type is determined by the value of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> = **dll**  
  
     [CAtlDllModuleT](../vs140/catldllmodulet-class.md) is used as the base class and the standard DLL entry points required for a COM server. These entry points are [DllMain](http://msdn.microsoft.com/library/windows/desktop/ms682583), [DllRegisterServer](http://msdn.microsoft.com/library/windows/desktop/ms682162), [DllUnRegisterServer](http://msdn.microsoft.com/library/windows/desktop/ms691457), [DllCanUnloadNow](http://msdn.microsoft.com/library/windows/desktop/ms690368), and [DllGetClassObject](http://msdn.microsoft.com/library/windows/desktop/dd797891).  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = **exe**  
  
     [CAtlExeModuleT](../vs140/catlexemodulet-class.md) is used as the base class and the standard executable entry point [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559).  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = **service**  
  
     [CAtlServiceModuleT](../vs140/catlservicemodulet-class.md) is used as the base class and the standard executable entry point [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559).  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> = **unspecified**  
  
     Disables injection of ATL code related to the module attribute.  
  
## Example  
 The following code shows how to create a library block in the generated .idl file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following code shows that you can provide your own implementation of a function that would appear in the code that was injected as a result of using **module**. See [/Fx](../vs140/-fx--merge-injected-code-.md) for more information on viewing injected code. In order to override one of the functions inserted by the **module** attribute, make a class that will contain your implementation of the function and make the **module** attribute apply to that class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
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
 [Class Attributes](../vs140/class-attributes.md)   
 [Stand-Alone Attributes](../vs140/stand-alone-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [usesgetlasterror](../vs140/usesgetlasterror.md)   
 [library](http://msdn.microsoft.com/library/windows/desktop/aa367069)   
 [helpcontext](../vs140/helpcontext.md)   
 [helpstring](../vs140/helpstring.md)   
 [helpfile](../vs140/helpfile.md)   
 [version](../vs140/version--c---.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)