---
title: "CObList Class"
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
  - "CObList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "objects [C++], lists of"
  - "CObList class"
  - "lists, object"
ms.assetid: 80699c93-33d8-4f8b-b8cf-7b58aeab64ca
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList Class
Supports ordered lists of nonunique <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> pointers accessible sequentially or by pointer value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CObList::CObList](#coblist__coblist)|Constructs an empty list for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> pointers.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CObList::AddHead](#coblist__addhead)|Adds an element (or all the elements in another list) to the head of the list (makes a new head).|  
|[CObList::AddTail](#coblist__addtail)|Adds an element (or all the elements in another list) to the tail of the list (makes a new tail).|  
|[CObList::Find](#coblist__find)|Gets the position of an element specified by pointer value.|  
|[CObList::FindIndex](#coblist__findindex)|Gets the position of an element specified by a zero-based index.|  
|[CObList::GetAt](#coblist__getat)|Gets the element at a given position.|  
|[CObList::GetCount](#coblist__getcount)|Returns the number of elements in this list.|  
|[CObList::GetHead](#coblist__gethead)|Returns the head element of the list (cannot be empty).|  
|[CObList::GetHeadPosition](#coblist__getheadposition)|Returns the position of the head element of the list.|  
|[CObList::GetNext](#coblist__getnext)|Gets the next element for iterating.|  
|[CObList::GetPrev](#coblist__getprev)|Gets the previous element for iterating.|  
|[CObList::GetSize](#coblist__getsize)|Returns the number of elements in this list.|  
|[CObList::GetTail](#coblist__gettail)|Returns the tail element of the list (cannot be empty).|  
|[CObList::GetTailPosition](#coblist__gettailposition)|Returns the position of the tail element of the list.|  
|[CObList::InsertAfter](#coblist__insertafter)|Inserts a new element after a given position.|  
|[CObList::InsertBefore](#coblist__insertbefore)|Inserts a new element before a given position.|  
|[CObList::IsEmpty](#coblist__isempty)|Tests for the empty list condition (no elements).|  
|[CObList::RemoveAll](#coblist__removeall)|Removes all the elements from this list.|  
|[CObList::RemoveAt](#coblist__removeat)|Removes an element from this list, specified by position.|  
|[CObList::RemoveHead](#coblist__removehead)|Removes the element from the head of the list.|  
|[CObList::RemoveTail](#coblist__removetail)|Removes the element from the tail of the list.|  
|[CObList::SetAt](#coblist__setat)|Sets the element at a given position.|  
  
## Remarks  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> lists behave like doubly-linked lists.  
  
 A variable of type **POSITION** is a key for the list. You can use a **POSITION** variable both as an iterator to traverse a list sequentially and as a bookmark to hold a place. A position is not the same as an index, however.  
  
 Element insertion is very fast at the list head, at the tail, and at a known **POSITION**. A sequential search is necessary to look up an element by value or index. This search can be slow if the list is long.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> macro to support serialization and dumping of its elements. If a list of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> pointers is stored to an archive, either with an overloaded insertion operator or with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function, each <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> element is serialized in turn.  
  
 If you need a dump of individual <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> elements in the list, you must set the depth of the dump context to 1 or greater.  
  
 When a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, only the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> pointers are removed, not the objects they reference.  
  
 You can derive your own classes from <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Your new list class, designed to hold pointers to objects derived from <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, adds new data members and new member functions. Note that the resulting list is not strictly type safe, because it allows insertion of any <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> pointer.  
  
> [!NOTE]
>  You must use the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro in the implementation of your derived class if you intend to serialize the list.  
  
 For more information on using <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
##  \<a name="coblist__addhead">\</a>  CObList::AddHead  
 Adds a new element or list of elements to the head of this list.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> pointer to be added to this list.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to another <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> list. The elements in <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> will be added to this list.  
  
### Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION AddHead( void\***  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  **);**\<br />\<br /> **void AddHead( CPtrList\***  <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION AddHead(const CString&**  <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION AddHead(LPCTSTR**  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  **);**\<br />\<br /> **void AddHead(CStringList\***  <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  **);**|  
  
### Remarks  
 The list can be empty before the operation.  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#89](../vs140/codesnippet/CPP/coblist-class_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__addtail">\</a>  CObList::AddTail  
 Adds a new element or list of elements to the tail of this list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> pointer to be added to this list.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to another <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> list. The elements in <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> will be added to this list.  
  
### Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
### Remarks  
 The list can be empty before the operation.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION AddTail( void\***  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  **);**\<br />\<br /> **void AddTail( CPtrList\***  <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION AddTail( const CString&**  <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION AddTail( LPCTSTR**  <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  **);**\<br />\<br /> **void AddTail( CStringList\***  <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  **);**|  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#90](../vs140/codesnippet/CPP/coblist-class_2.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__coblist">\</a>  CObList::CObList  
 Constructs an empty <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> pointer list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The memory-allocation granularity for extending the list.  
  
### Remarks  
 As the list grows, memory is allocated in units of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> entries. If a memory allocation fails, a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is thrown.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**CPtrList( INT_PTR**  <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  **= 10 );**|  
|[CStringList](../vs140/cstringlist-class.md)|**CStringList( INT_PTR**  <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  **= 10 );**|  
  
### Example  
  Below is a listing of the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>-derived class <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> used in all the collection examples:  
  
 [!code[NVC_MFCCollections#91](../vs140/codesnippet/CPP/coblist-class_3.h)]  
  
 Below is an example of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> constructor usage:  
  
 [!code[NVC_MFCCollections#92](../vs140/codesnippet/CPP/coblist-class_4.cpp)]  
  
##  \<a name="coblist__find">\</a>  CObList::Find  
 Searches the list sequentially to find the first <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> pointer matching the specified <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> pointer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The object pointer to be found in this list.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The start position for the search.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the object is not found.  
  
### Remarks  
 Note that the pointer values are compared, not the contents of the objects.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION Find( void\***  <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> **, POSITION**  <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  **= NULL ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION Find( LPCTSTR**  <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> **, POSITION**  <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  **= NULL ) const;**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#93](../vs140/codesnippet/CPP/coblist-class_5.cpp)]  
  
##  \<a name="coblist__findindex">\</a>  CObList::FindIndex  
 Uses the value of <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> as an index into the list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The zero-based index of the list element to be found.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is too large. (The framework generates an assertion if <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is negative.)  
  
### Remarks  
 It starts a sequential scan from the head of the list, stopping on the                         *n*th element.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION FindIndex( INT_PTR**  <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  **) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION FindIndex( INT_PTR**  <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  **) const;**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#94](../vs140/codesnippet/CPP/coblist-class_6.cpp)]  
  
##  \<a name="coblist__getat">\</a>  CObList::GetAt  
 A variable of type **POSITION** is a key for the list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> or **Find** member function call.  
  
### Return Value  
 See the return value description for [GetHead](#coblist__gethead).  
  
### Remarks  
 It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> retrieves the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> pointer associated with a given position.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**const void\*& GetAt( POSITION**  *position*  **) const;**\<br />\<br /> **void\*& GetAt( POSITION**  *position*  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**const CString& GetAt( POSITION**  *position*  **) const;**\<br />\<br /> **CString& GetAt( POSITION**  *position*  **);**|  
  
### Example  
  See the example for [FindIndex](#coblist__findindex).  
  
##  \<a name="coblist__getcount">\</a>  CObList::GetCount  
 Gets the number of elements in this list.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 An integer value containing the element count.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**INT_PTR GetCount( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**INT_PTR GetCount( ) const;**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#95](../vs140/codesnippet/CPP/coblist-class_7.cpp)]  
  
##  \<a name="coblist__gethead">\</a>  CObList::GetHead  
 Gets the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> pointer that represents the head element of this list.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 If the list is accessed through a pointer to a **const CObList**, then <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> pointer. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> returns a reference to a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> pointer. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#coblist__isempty) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**const void\*& GetHead( ) const; void\*& GetHead( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**const CString& GetHead( ) const; CString& GetHead( );**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> class.  
  
 The following example illustrates the use of <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> on the left side of an assignment statement.  
  
 [!code[NVC_MFCCollections#96](../vs140/codesnippet/CPP/coblist-class_8.cpp)]  
  
##  \<a name="coblist__getheadposition">\</a>  CObList::GetHeadPosition  
 Gets the position of the head element of this list.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION GetHeadPosition( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION GetHeadPosition( ) const;**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#97](../vs140/codesnippet/CPP/coblist-class_9.cpp)]  
  
##  \<a name="coblist__getnext">\</a>  CObList::GetNext  
 Gets the list element identified by <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> value of the next entry in the list.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> value returned by a previous <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, or other member function call.  
  
### Return Value  
 See the return value description for [GetHead](#coblist__gethead).  
  
### Remarks  
 You can use <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
 You must ensure that your <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
 It is possible to remove an element during an iteration. See the example for [RemoveAt](#coblist__removeat).  
  
> [!NOTE]
>  As of MFC 8.0 the const version of this method has changed to return <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  This change was made to bring the compiler into conformance with the C++ standard.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|  
|[CStringList](../vs140/cstringlist-class.md)|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#98](../vs140/codesnippet/CPP/coblist-class_10.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__getprev">\</a>  CObList::GetPrev  
 Gets the list element identified by <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> value of the previous entry in the list.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> value returned by a previous <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> or other member function call.  
  
### Return Value  
 See the return value description for [GetHead](#coblist__gethead).  
  
### Remarks  
 You can use <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> in a reverse iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
 You must ensure that your <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the first in the list, then the new value of <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  As of MFC 8.0 the const version of this method has changed to return <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  This change was made to bring the compiler into conformance with the C++ standard.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|  
|[CStringList](../vs140/cstringlist-class.md)|<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>|  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#99](../vs140/codesnippet/CPP/coblist-class_11.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__getsize">\</a>  CObList::GetSize  
 Returns the number of list elements.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the list.  
  
### Remarks  
 Call this method to retrieve the number of elements in the list.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**INT_PTR GetSize( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**INT_PTR GetSize( ) const;**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#100](../vs140/codesnippet/CPP/coblist-class_12.cpp)]  
  
##  \<a name="coblist__gettail">\</a>  CObList::GetTail  
 Gets the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> pointer that represents the tail element of this list.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 See the return value description for [GetHead](#coblist__gethead).  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#coblist__isempty) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**const void\*& GetTail( ) const; void\*& GetTail( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**const CString& GetTail( ) const; CString& GetTail( );**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#101](../vs140/codesnippet/CPP/coblist-class_13.cpp)]  
  
##  \<a name="coblist__gettailposition">\</a>  CObList::GetTailPosition  
 Gets the position of the tail element of this list; **NULL** if the list is empty.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION GetTailPosition( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION GetTailPosition( ) const;**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#102](../vs140/codesnippet/CPP/coblist-class_14.cpp)]  
  
##  \<a name="coblist__insertafter">\</a>  CObList::InsertAfter  
 Adds an element to this list after the element at the specified position.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The object pointer to be added to this list.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION InsertAfter( POSITION**  *position* **, void\***  <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION InsertAfter( POSITION**  *position* **, const CString&**  <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION InsertAfter( POSITION**  *position* **, LPCTSTR**  <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  **);**|  
  
### Return Value  
 A **POSITION** value which is the same as the                         *position* parameter.  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#103](../vs140/codesnippet/CPP/coblist-class_15.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__insertbefore">\</a>  CObList::InsertBefore  
 Adds an element to this list before the element at the specified position.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The object pointer to be added to this list.  
  
### Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION InsertBefore( POSITION**  *position* **, void\***  <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION InsertBefore( POSITION**  *position* **, const CString&**  <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION InsertBefore( POSITION**  *position* **, LPCTSTR**  <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  **);**|  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#104](../vs140/codesnippet/CPP/coblist-class_16.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__isempty">\</a>  CObList::IsEmpty  
 Indicates whether this list contains no elements.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if this list is empty; otherwise 0.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**BOOL IsEmpty( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**BOOL IsEmpty( ) const;**|  
  
### Example  
  See the example for [RemoveAll](#coblist__removeall).  
  
##  \<a name="coblist__removeall">\</a>  CObList::RemoveAll  
 Removes all the elements from this list and frees the associated <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> memory.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 No error is generated if the list is already empty.  
  
 When you remove elements from a <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>, you remove the object pointers from the list. It is your responsibility to delete the objects themselves.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void RemoveAll( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**void RemoveAll( );**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#105](../vs140/codesnippet/CPP/coblist-class_17.cpp)]  
  
##  \<a name="coblist__removeat">\</a>  CObList::RemoveAt  
 Removes the specified element from this list.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *position*  
 The position of the element to be removed from the list.  
  
### Remarks  
 When you remove an element from a <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>, you remove the object pointer from the list. It is your responsibility to delete the objects themselves.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void RemoveAt( POSITION**  *position*  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**void RemoveAt( POSITION**  *position*  **);**|  
  
### Example  
  Be careful when removing an element during a list iteration. The following example shows a removal technique that guarantees a valid **POSITION** value for [GetNext](#coblist__getnext).  
  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#106](../vs140/codesnippet/CPP/coblist-class_18.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
  
##  \<a name="coblist__removehead">\</a>  CObList::RemoveHead  
 Removes the element from the head of the list and returns a pointer to it.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> pointer previously at the head of the list.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#coblist__isempty) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void\* RemoveHead( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**CString RemoveHead( );**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#107](../vs140/codesnippet/CPP/coblist-class_19.cpp)]  
  
##  \<a name="coblist__removetail">\</a>  CObList::RemoveTail  
 Removes the element from the tail of the list and returns a pointer to it.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the object that was at the tail of the list.  
  
### Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](#coblist__isempty) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void\* RemoveTail( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**CString RemoveTail( );**|  
  
### Example  
 See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#108](../vs140/codesnippet/CPP/coblist-class_20.cpp)]  
  
##  \<a name="coblist__setat">\</a>  CObList::SetAt  
 Sets the element at a given position.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 The **POSITION** of the element to be set.  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> pointer to be written to the list.  
  
### Remarks  
 A variable of type **POSITION** is a key for the list. It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> writes the <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> pointer to the specified position in the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void SetAt( POSITION**  <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> **, const CString&**  <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**void SetAt( POSITION**  <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  **);**|  
  
### Example  
  See [CObList::CObList](#coblist__coblist) for a listing of the <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#109](../vs140/codesnippet/CPP/coblist-class_21.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStringList](../vs140/cstringlist-class.md)   
 [CPtrList](../vs140/cptrlist-class.md)