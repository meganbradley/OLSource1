---
title: "CComMultiThreadModel Class"
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
  - "CComMultiThreadModel"
  - "ATL.CComMultiThreadModel"
  - "ATL::CComMultiThreadModel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, multithreading"
  - "CComMultiThreadModel class"
  - "threading [ATL]"
ms.assetid: db8f1662-2f7a-44b3-b341-ffbfb6e422a3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModel Class
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provides thread-safe methods for incrementing and decrementing the value of a variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md)|References class [CComAutoCriticalSection](../vs140/ccomautocriticalsection-class.md).|  
|[CComMultiThreadModel::CriticalSection](../vs140/ccommultithreadmodel--criticalsection.md)|References class [CComCriticalSection](../vs140/ccomcriticalsection-class.md).|  
|[CComMultiThreadModel::ThreadModelNoCS](../vs140/ccommultithreadmodel--threadmodelnocs.md)|References class [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md).|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComMultiThreadModel::Decrement](../vs140/ccommultithreadmodel--decrement.md)|(Static) Decrements the value of the specified variable in a thread-safe manner.|  
|[CComMultiThreadModel::Increment](../vs140/ccommultithreadmodel--increment.md)|(Static) Increments the value of the specified variable in a thread-safe manner.|  
  
## Remarks  
 Typically, you use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> through one of two <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> names, either [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md) or [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md). The class referenced by each <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> depends on the threading model used, as shown in the following table:  
  
|typedef|Single threading|Apartment threading|Free threading|  
|-------------|----------------------|-------------------------|--------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|S|S|M|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|S|M|M|  
  
 S= <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; M= <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> itself defines three <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> names. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> reference classes that provide methods for obtaining and releasing ownership of a critical section. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> references class [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccommultithreadmodel__autocriticalsection">\</a>  CComMultiThreadModel::AutoCriticalSection  
 When using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> references class [CComAutoCriticalSection](../vs140/ccomautocriticalsection-class.md), which provides methods for obtaining and releasing ownership of a critical section object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) also contain definitions for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> name [CriticalSection](../vs140/ccommultithreadmodel--criticalsection.md). You should not specify <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 The following code is modeled after [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), and demonstrates <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> being used in a threading environment.  
  
 [!code[NVC_ATL_COM#36](../vs140/codesnippet/CPP/ccommultithreadmodel-class_1.h)]  
  
 The following tables show the results of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> methods, depending on the **ThreadModel** template parameter and the threading model used by the application:  
  
### ThreadModel = CComObjectThreadModel  
  
|Method|Single or Apartment Threading|Free Threading|  
|------------|-----------------------------------|--------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|The increment is not thread-safe.|The increment is thread-safe.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Does nothing; there is no critical section to lock.|The critical section is locked.|  
  
### ThreadModel = CComObjectThreadModel::ThreadModelNoCS  
  
|Method|Single or Apartment Threading|Free Threading|  
|------------|-----------------------------------|--------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The increment is not thread-safe.|The increment is thread-safe.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Does nothing; there is no critical section to lock.|Does nothing; there is no critical section to lock.|  
  
##  \<a name="ccommultithreadmodel__criticalsection">\</a>  CComMultiThreadModel::CriticalSection  
 When using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> references class [CComCriticalSection](../vs140/ccomcriticalsection-class.md), which provides methods for obtaining and releasing ownership of a critical section object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) also contain definitions for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> name [AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md). You should not specify <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
##  \<a name="ccommultithreadmodel__decrement">\</a>  CComMultiThreadModel::Decrement  
 This static function calls the Win32 function [InterlockedDecrement](http://msdn.microsoft.com/library/windows/desktop/ms683580), which decrements the value of the variable pointed to by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 [in] Pointer to the variable to be decremented.  
  
### Return Value  
 If the result of the decrement is 0, then <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> returns 0. If the result of the decrement is nonzero, the return value is also nonzero but may not equal the result of the decrement.  
  
### Remarks  
 **InterlockedDecrement** prevents more than one thread from simultaneously using this variable.  
  
##  \<a name="ccommultithreadmodel__increment">\</a>  CComMultiThreadModel::Increment  
 This static function calls the Win32 function [InterlockedIncrement](http://msdn.microsoft.com/library/windows/desktop/ms683614), which increments the value of the variable pointed to by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 [in] Pointer to the variable to be incremented.  
  
### Return Value  
 If the result of the increment is 0, then **Increment** returns 0. If the result of the increment is nonzero, the return value is also nonzero but may not equal the result of the increment.  
  
### Remarks  
 **InterlockedIncrement** prevents more than one thread from simultaneously using this variable.  
  
##  \<a name="ccommultithreadmodel__threadmodelnocs">\</a>  CComMultiThreadModel::ThreadModelNoCS  
 When using <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> references class [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> provides thread-safe methods for incrementing and decrementing a variable; however, it does not provide a critical section.  
  
 [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> also contain definitions for <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the class referenced by <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|  
  
### Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## See Also  
 [CComSingleThreadModel Class](../vs140/ccomsinglethreadmodel-class.md)   
 [CComAutoCriticalSection Class](../vs140/ccomautocriticalsection-class.md)   
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)