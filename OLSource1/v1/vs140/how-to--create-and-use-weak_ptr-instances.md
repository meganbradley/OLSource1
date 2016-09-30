---
title: "How to: Create and Use weak_ptr Instances"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 8dd6909b-b070-4afa-9696-f2fc94579c65
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create and Use weak_ptr Instances
Sometimes an object must store a way to access the underlying object of a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> without causing the reference count to be incremented. Typically, this situation occurs when you have cyclic references between <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instances.  
  
 The best design is to avoid shared ownership of pointers whenever you can. However, if you must have shared ownership of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instances, avoid cyclic references between them. When cyclic references are unavoidable, or even preferable for some reason, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to give one or more of the owners a weak reference to another <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. By using a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you can create a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that joins to an existing set of related instances, but only if the underlying memory resource is still valid. A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> itself does not participate in the reference counting, and therefore, it cannot prevent the reference count from going to zero. However, you can use a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to try to obtain a new copy of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with which it was initialized. If the memory has already been deleted, a **bad_weak_ptr** exception is thrown. If the memory is still valid, the new shared pointer increments the reference count and guarantees that the memory will be valid as long as the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable stays in scope.  
  
## Example  
 The following code example shows a case where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is used to ensure proper deletion of objects that have circular dependencies. As you examine the example, assume that it was created only after alternative solutions were considered. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects represent some aspect of a machine process, and they operate independently. Each controller must be able to query the status of the other controllers at any time, and each one contains a private <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for this purpose. Each vector contains a circular reference, and therefore, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instances are used instead of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [!code[stl_smart_pointers#222](../vs140/codesnippet/CPP/how-to--create-and-use-weak_ptr-instances_1.cpp)]  
  
 **Creating Controller0Creating Controller1Creating Controller2Creating Controller3Creating Controller4push_back to v[0]: 1push_back to v[0]: 2push_back to v[0]: 3push_back to v[0]: 4push_back to v[1]: 0push_back to v[1]: 2push_back to v[1]: 3push_back to v[1]: 4push_back to v[2]: 0push_back to v[2]: 1push_back to v[2]: 3push_back to v[2]: 4push_back to v[3]: 0push_back to v[3]: 1push_back to v[3]: 2push_back to v[3]: 4push_back to v[4]: 0push_back to v[4]: 1push_back to v[4]: 2push_back to v[4]: 3use_count = 1Status of 1 = OnStatus of 2 = OnStatus of 3 = OnStatus of 4 = Onuse_count = 1Status of 0 = OnStatus of 2 = OnStatus of 3 = OnStatus of 4 = Onuse_count = 1Status of 0 = OnStatus of 1 = OnStatus of 3 = OnStatus of 4 = Onuse_count = 1Status of 0 = OnStatus of 1 = OnStatus of 2 = OnStatus of 4 = Onuse_count = 1Status of 0 = OnStatus of 1 = OnStatus of 2 = OnStatus of 3 = OnDestroying Controller0Destroying Controller1Destroying Controller2Destroying Controller3Destroying Controller4Press any key** As an experiment, modify the vector <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to be a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and then in the output, notice that no destructors are invoked when <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returns.  
  
## See Also  
 [Smart Pointers](../vs140/smart-pointers--modern-c---.md)