---
title: "unique_lock Class"
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
  - "mutex/std::unique_lock"
dev_langs: 
  - "C++"
ms.assetid: f4ed8ba9-c8af-446f-8ef0-0b356bad14bd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock Class
Represents a template that can be instantiated to create objects that manage the locking and unlocking of a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template argument <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must name a *mutex type*.  
  
 Internally, a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> stores a pointer to an associated <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object and a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that indicates whether the current thread owns the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Synonym for the template argument <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[unique_lock::unique_lock Constructor](#unique_lock__unique_lock_constructor)|Constructs a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[unique_lock::~unique_lock Destructor](#unique_lock___dtorunique_lock_destructor)|Releases any resources that are associated with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[unique_lock::lock Method](#unique_lock__lock_method)|Blocks the calling thread until the thread obtains ownership of the associated <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[unique_lock::mutex Method](#unique_lock__mutex_method)|Retrieves the stored pointer to the associated <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[unique_lock::owns_lock Method](#unique_lock__owns_lock_method)|Specifies whether the calling thread owns the associated <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[unique_lock::release Method](#unique_lock__release_method)|Disassociates the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object from the associated <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|[unique_lock::swap Method](#unique_lock__swap_method)|Swaps the associated <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and ownership status with that of a specified object.|  
|[unique_lock::try_lock Method](#unique_lock__try_lock_method)|Attempts to obtain ownership of the associated <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> without blocking.|  
|[unique_lock::try_lock_for Method](#unique_lock__try_lock_for_method)|Attempts to obtain ownership of the associated <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> without blocking.|  
|[unique_lock::try_lock_until Method](#unique_lock__try_lock_until_method)|Attempts to obtain ownership of the associated <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> without blocking.|  
|[unique_lock::unlock Method](#unique_lock__unlock_method)|Releases ownership of the associated <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[unique_lock::operator bool Operator](#unique_lock__operator_bool)|Specifies whether the calling thread has ownership of the associated <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|[unique_lock::operator= Operator](#unique_lock__operator_eq)|Copies the stored <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> pointer and associated ownership status from a specified object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
##  \<a name="unique_lock__lock_method">\</a>  unique_lock::lock Method  
 Blocks the calling thread until the thread obtains ownership of the associated <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the stored <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, this method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the associated <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, this method throws a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
 Otherwise, this method calls <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on the associated <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and sets the internal thread ownership flag to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__mutex_method">\</a>  unique_lock::mutex Method  
 Retrieves the stored pointer to the associated <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="unique_lock__operator_bool">\</a>  unique_lock::operator bool  
 Specifies whether the calling thread has ownership of the associated mutex.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> if the thread owns the mutex; otherwise <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__operator_eq">\</a>  unique_lock::operator=  
 Copies the stored <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> pointer and associated ownership status from a specified object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
### Remarks  
 If the calling thread owns the previously associated <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, before this method calls <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> on the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, it assigns the new values.  
  
 After the copy, this method sets <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to a default-constructed state.  
  
##  \<a name="unique_lock__owns_lock_method">\</a>  unique_lock::owns_lock Method  
 Specifies whether the calling thread owns the associated <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> if the thread owns the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__release_method">\</a>  unique_lock::release Method  
 Disassociates the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object from the associated <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The previous value of the stored <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> pointer.  
  
### Remarks  
 This method sets the value of the stored <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> pointer to 0 and sets the internal <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> ownership flag to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__swap_method">\</a>  unique_lock::swap Method  
 Swaps the associated <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and ownership status with that of a specified object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
##  \<a name="unique_lock__try_lock_method">\</a>  unique_lock::try_lock Method  
 Attempts to obtain ownership of the associated <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the stored <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, the method throws a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__try_lock_for_method">\</a>  unique_lock::try_lock_for Method  
 Attempts to obtain ownership of the associated <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the stored <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, the method throws a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__try_lock_until_method">\</a>  unique_lock::try_lock_until Method  
 Attempts to obtain ownership of the associated <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> without blocking.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the stored <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, the method throws a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
##  \<a name="unique_lock__unique_lock_constructor">\</a>  unique_lock::unique_lock Constructor  
 Constructs a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A mutex type object.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor constructs an object that has an associated mutex pointer value of 0.  
  
 The second constructor moves the associated mutex status from <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>. After the move, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is no longer associated with a mutex.  
  
 The remaining constructors store & <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> as the stored <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> pointer. Ownership of the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> is determined by the second argument, if it exists.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|Ownership is obtained by calling the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> method on the associated <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>|Ownership is assumed. <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> must be locked when the constructor is called.|  
|<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|The calling thread is assumed not to own the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> must not be locked when the constructor is called.|  
|<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|Ownership is determined by calling <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> on the associated <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> object. The constructor throws nothing.|  
|<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>|Ownership is determined by calling <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|Ownership is determined by calling <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.|  
  
##  \<a name="unique_lock___dtorunique_lock_destructor">\</a>  unique_lock::~unique_lock Destructor  
 Releases any resources that are associated with the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread owns the associated <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>, the destructor releases ownership by calling unlock on the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object.  
  
##  \<a name="unique_lock__unlock_method">\</a>  unique_lock::unlock Method  
 Releases ownership of the associated <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 If the calling thread doesn't own the associated <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, this method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
 Otherwise, this method calls <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> on the associated <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> and sets the internal thread ownership flag to <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)