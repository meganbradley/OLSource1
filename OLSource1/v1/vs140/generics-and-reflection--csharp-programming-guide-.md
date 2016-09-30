---
title: "Generics and Reflection (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "generics [C#], reflection"
  - "reflection [C#], generic types"
ms.assetid: 162fd9b4-dd5b-4abb-8c9b-e44e21e2f451
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generics and Reflection (C# Programming Guide)
Because the Common Language Runtime (CLR) has access to generic type information at run time, you can use reflection to obtain information about generic types in the same way as for non-generic types. For more information, see [Generics in the Runtime (C# Programming Guide)](../vs140/generics-in-the-run-time--csharp-programming-guide-.md).  
  
 In the [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)] several new members are added to the \<xref:System.Type*> class to enable run-time information for generic types. See the documentation on these classes for more information on how to use these methods and properties. The \<xref:System.Reflection.Emit*> namespace also contains new members that support generics. See [How to: Define a Generic Type with Reflection Emit](assetId:///07d5f01a-7b5b-40ea-9b15-f21561098fe4).  
  
 For a list of the invariant conditions for terms used in generic reflection, see the \<xref:System.Type.IsGenericType*> property remarks.  
  
|System.Type Member Name|Description|  
|-----------------------------|-----------------|  
|\<xref:System.Type.IsGenericType*>|Returns true if a type is generic.|  
|\<xref:System.Type.GetGenericArguments*>|Returns an array of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> objects that represent the type arguments supplied for a constructed type, or the type parameters of a generic type definition.|  
|\<xref:System.Type.GetGenericTypeDefinition*>|Returns the underlying generic type definition for the current constructed type.|  
|\<xref:System.Type.GetGenericParameterConstraints*>|Returns an array of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects that represent the constraints on the current generic type parameter.|  
|\<xref:System.Type.ContainsGenericParameters*>|Returns true if the type or any of its enclosing types or methods contain type parameters for which specific types have not been supplied.|  
|\<xref:System.Type.GenericParameterAttributes*>|Gets a combination of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> flags that describe the special constraints of the current generic type parameter.|  
|\<xref:System.Type.GenericParameterPosition*>|For a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that represents a type parameter, gets the position of the type parameter in the type parameter list of the generic type definition or generic method definition that declared the type parameter.|  
|\<xref:System.Type.IsGenericParameter*>|Gets a value that indicates whether the current <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents a type parameter of a generic type or method definition.|  
|\<xref:System.Type.IsGenericTypeDefinition*>|Gets a value that indicates whether the current \<xref:System.Type*> represents a generic type definition, from which other generic types can be constructed. Returns true if the type represents the definition of a generic type.|  
|\<xref:System.Type.DeclaringMethod*>|Returns the generic method that defined the current generic type parameter, or null if the type parameter was not defined by a generic method.|  
|\<xref:System.Type.MakeGenericType*>|Substitutes the elements of an array of types for the type parameters of the current generic type definition, and returns a \<xref:System.Type*> object representing the resulting constructed type.|  
  
 In addition, new members are added to the \<xref:System.Reflection.MethodInfo*> class to enable run-time information for generic methods. See the \<xref:System.Reflection.MethodInfo.IsGenericMethod*> property remarks for a list of invariant conditions for terms used to reflect on generic methods.  
  
|System.Reflection.MemberInfo Member Name|Description|  
|----------------------------------------------|-----------------|  
|\<xref:System.Reflection.MethodInfo.IsGenericMethod*>|Returns true if a method is generic.|  
|\<xref:System.Reflection.MethodInfo.GetGenericArguments*>|Returns an array of Type objects that represent the type arguments of a constructed generic method or the type parameters of a generic method definition.|  
|\<xref:System.Reflection.MethodInfo.GetGenericMethodDefinition*>|Returns the underlying generic method definition for the current constructed method.|  
|\<xref:System.Reflection.MethodInfo.ContainsGenericParameters*>|Returns true if the method or any of its enclosing types contain any type parameters for which specific types have not been supplied.|  
|\<xref:System.Reflection.MethodInfo.IsGenericMethodDefinition*>|Returns true if the current \<xref:System.Reflection.MethodInfo*> represents the definition of a generic method.|  
|\<xref:System.Reflection.MethodInfo.MakeGenericMethod*>|Substitutes the elements of an array of types for the type parameters of the current generic method definition, and returns a \<xref:System.Reflection.MethodInfo*> object representing the resulting constructed method.|  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C#)](../vs140/generics--csharp-programming-guide-.md)   
 [Overview of Reflection and Generics](assetId:///f7180fc5-dd41-42d4-8a8e-1b34288e06de)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)