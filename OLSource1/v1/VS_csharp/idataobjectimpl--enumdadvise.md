---
title: "IDataObjectImpl::EnumDAdvise"
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
  - "EnumDAdvise"
  - "IDataObjectImpl::EnumDAdvise"
  - "IDataObjectImpl.EnumDAdvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnumDAdvise method"
ms.assetid: e180c398-0904-469e-b25b-0352a0eba684
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDataObjectImpl::EnumDAdvise
Creates an enumerator to iterate through the current advisory connections.  
  
## Syntax  
  
```  
  
      HRESULT DAdvise(  
   FORMATETC* pformatetc,  
   DWORD advf,  
   IAdviseSink* pAdvSink,  
   DWORD* pdwConnection   
);  
```  
  
## Remarks  
 See [IDataObject::EnumDAdvise](http://msdn.microsoft.com/library/windows/desktop/ms680127) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IDataObjectImpl Class](../VS_csharp/idataobjectimpl-class.md)   
 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177)   
 [IAdviseSink](http://msdn.microsoft.com/library/windows/desktop/ms692513)