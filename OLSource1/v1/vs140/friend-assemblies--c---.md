---
title: "Friend Assemblies (C++)"
ms.custom: na
ms.date: "09/23/2016"
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
  - "friend assemblies, Visual C++"
ms.assetid: 8d55fee0-b7c2-4fbe-a23b-dfe424dc71cd
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Friend Assemblies (C++)
For applicable runtimes, the *friend assemblies* language feature makes types that are at namespace scope or global scope in an assembly component accessible to one or more client assemblies or .netmodules.  
  
## All Runtimes  
 **Remarks**  
  
 (This language feature is not supported in all runtimes.)  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Remarks**  
  
 (This language feature is not supported in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
#### To make types at namespace scope or global scope in an assembly component accessible to a client assembly or .netmodule  
  
1.  In the component, specify an assembly attribute \<xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute*>, and pass the name of the client assembly or .netmodule that will access types at namespace scope or global scope in the component.  You can specify multiple client assemblies or .netmodules by specifying additional attributes.  
  
2.  In the client assembly or .netmodule, when you reference the component assembly by using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, pass the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute.  If you specify the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute for an assembly that does not specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, a runtime exception will be thrown if you try to access a type at namespace scope or global scope in the component.  
  
 A build error will result if the assembly that contains the \<xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute*> attribute does not have a strong name but the client assembly that uses the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute does.  
  
 Although types at namespace scope and global scope can be known to a client assembly or .netmodule, member accessibility is still in effect.  For example, you cannot access a private member.  
  
 Access to all types in an assembly must be explicitly granted.  For example, assembly C does not have access to all types in assembly A if assembly C references assembly B and assembly B has access to all types in assembly A.  
  
 For information about how to specify the accessibility of types outside an assembly, see [Type Visibility](../vs140/type-visibility.md).  
  
 For information about how to sign—that is, how to give a strong name to—an assembly that is built by using the Visual C++ compiler, see [Strong Name Assemblies (Assembly Signing)](../vs140/strong-name-assemblies--assembly-signing---c---cli-.md).  
  
 As an alternative to using the friend assemblies feature, you can use \<xref:System.Security.Permissions.StrongNameIdentityPermission*> to restrict access to individual types.  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 The following code example defines a component that specifies a client assembly that has access to the types in the component.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The next code example accesses a private type in the component.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 The next code example defines a component but does not specify a client assembly that will have access to the types in the component.  
  
 Notice that the component is linked by using **/opt:noref**. This ensures that private types are emitted in the component's metadata, which is not required when the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute is present. For more information, see [/OPT (Optimizations)](../vs140/-opt--optimizations-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following code example defines a client that tries to access a private type in a component that does not give access to its private types. Because of the behavior of the runtime, if you want to catch the exception, you must attempt to access a private type in a helper function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 The next code example shows how to create a strong-name component that specifies a client assembly that will have access to the types in the component.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Notice that the component must specify its public key. We suggest that you run the following commands sequentially at a command prompt to create a key pair and get the public key:  
  
 **sn -d friend_assemblies.snk**  
  
 **sn -k friend_assemblies.snk**  
  
 **sn -i friend_assemblies.snk friend_assemblies.snk**  
  
 **sn -pc friend_assemblies.snk key.publickey**  
  
 **sn -tp key.publickey**  
  
 The next code example accesses a private type in the strong-name component.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)