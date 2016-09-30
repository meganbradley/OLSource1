---
title: "create_accelerator_view Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amprt/Concurrency::direct3d::create_accelerator_view"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "create_accelerator_view function"
ms.assetid: 2ab7f14a-db10-4ff2-815d-eb43824fb790
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# create_accelerator_view Function
Creates an [accelerator_view](../vs140/accelerator_view-class.md) object from a pointer to a Direct3D device interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The accelerator on which the new accelerator_view is to be created.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The pointer to the Direct3D device interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether timeout should be disabled for the newly created accelerator_view. This corresponds to the D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT flag for Direct3D device creation and is used to indicate if the operating system should allow workloads that take more than 2 seconds to execute without resetting the device per the Windows timeout detection and recovery mechanism. Use of this flag is recommended if you need to perform time consuming tasks on the accelerator_view.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The [queuing_mode](../vs140/queuing_mode-enumeration.md) to be used for the newly created accelerator_view. This parameter has a default value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object created from the passed Direct3D device interface.  
  
## Remarks  
 This function creates a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object from an existing pointer to a Direct3D device interface. If the function call succeeds, the reference count of the parameter is incremented by means of an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> call to the interface. You can safely release the object when it is no longer required in your DirectX code. If the method call fails, a [runtime_exception](../vs140/runtime_exception-class.md) is thrown.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object that you create by using this function is thread safe. You must synchronize concurrent use of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. Unsynchronized concurrent usage of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object and the raw ID3D11Device interface causes undefined behavior.  
  
 The C++ AMP runtime provides detailed error information in debug mode by using the D3D Debug layer if you use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> flag.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [Concurrency::direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)