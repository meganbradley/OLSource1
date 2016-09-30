---
title: "AtlGetObjectSourceInterface"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::AtlGetObjectSourceInterface"
  - "ATL.AtlGetObjectSourceInterface"
  - "AtlGetObjectSourceInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetObjectSourceInterface function"
ms.assetid: a8528f45-fbfb-4e24-ad1a-1d69b2897155
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetObjectSourceInterface
Call this function to retrieve information about the default source interface of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the object for which information is to be returned.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to the LIBID of the type library containing the definition of the source interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to the interface ID of the object's default source interface.  
  
 *pdwMajor*  
 [out] A pointer to the major version number of the type library containing the definition of the source interface.  
  
 *pdwMinor*  
 [out] A pointer to the minor version number of the type library containing the definition of the source interface.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can provide you with the interface ID of the default source interface, along with the LIBID and major and minor version numbers of the type library describing that interface.  
  
> [!NOTE]
>  For this function to successfully retrieve the requested information, the object represented by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must implement <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (and return type information through **IDispatch::GetTypeInfo**) plus it must also implement either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The type information for the source interface must be in the same type library as the type information for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 The example below shows how you might define an event sink class, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, that reduces the number of template arguments that you can pass to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to the bare essentials. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to initialize the [IDispEventImpl](../vs140/idispeventimpl-class.md) members before calling [DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md) or [DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md).  
  
 [!code[NVC_ATL_Windowing#93](../vs140/codesnippet/CPP/atlgetobjectsourceinterface_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [IDispEventImpl Class](../vs140/idispeventimpl-class.md)   
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)