---
title: "IPropertyProxyEESide::ResolveAssemblyRef"
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
  - "IPropertyProxyEESide::ResolveAssemblyRef"
helpviewer_keywords: 
  - "IPropertyProxyEESide::ResolveAssemblyRef"
ms.assetid: 662ca0a6-dad0-4c00-a718-bb3bbc5bd9da
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IPropertyProxyEESide::ResolveAssemblyRef
Determines the location of the specified managed assembly reference.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Name of the assembly to resolve.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEEDataStorage](../vs140/ieedatastorage.md) object containing the assembly bytes associated with the reference.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object containing the symbol store data associated with this reference.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the path location of this reference.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns a value from the [ASSEMBLYLOCRESOLUTION](../vs140/assemblylocresolution.md) enumeration indicating the location of this reference's assembly.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is not typically implemented by a custom expression evaluator.  
  
## See Also  
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [IEEDataStorage](../vs140/ieedatastorage.md)   
 [ASSEMBLYLOCRESOLUTION](../vs140/assemblylocresolution.md)