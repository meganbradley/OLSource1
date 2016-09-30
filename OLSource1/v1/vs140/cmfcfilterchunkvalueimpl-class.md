---
title: "CMFCFilterChunkValueImpl Class"
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
  - "CMFCFilterChunkValueImpl"
  - "afxwin/CMFCFilterChunkValueImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCFilterChunkValueImpl class"
ms.assetid: 3c833f23-5b88-4d08-9e09-ca6a8aec88bf
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCFilterChunkValueImpl Class
This is a class which simplifies both chunk and property value pair logic.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCFilterChunkValueImpl::~CMFCFilterChunkValueImpl](#cmfcfilterchunkvalueimpl___dtorcmfcfilterchunkvalueimpl)|Destructs the object.|  
|[CMFCFilterChunkValueImpl::CMFCFilterChunkValueImpl](#cmfcfilterchunkvalueimpl__cmfcfilterchunkvalueimpl)|Constructs the object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCFilterChunkValueImpl::Clear](#cmfcfilterchunkvalueimpl__clear)|Clears the ChunkValue.|  
|[CMFCFilterChunkValueImpl::CopyChunk](#cmfcfilterchunkvalueimpl__copychunk)|Copies this chunk to a structure describing the characteristics of a chunk.|  
|[CMFCFilterChunkValueImpl::CopyFrom](#cmfcfilterchunkvalueimpl__copyfrom)|Initializes this chunk value from the other value.|  
|[CMFCFilterChunkValueImpl::GetChunkGUID](#cmfcfilterchunkvalueimpl__getchunkguid)|Retrieves the chunk GUID.|  
|[CMFCFilterChunkValueImpl::GetChunkPID](#cmfcfilterchunkvalueimpl__getchunkpid)|Retrieves the chunk PID (property ID).|  
|[CMFCFilterChunkValueImpl::GetChunkType](#cmfcfilterchunkvalueimpl__getchunktype)|Gets chunk type.|  
|[CMFCFilterChunkValueImpl::GetString](#cmfcfilterchunkvalueimpl__getstring)|Retrieves the the string value.|  
|[CMFCFilterChunkValueImpl::GetValue](#cmfcfilterchunkvalueimpl__getvalue)|Retrieves the value as an allocated propvariant.|  
|[CMFCFilterChunkValueImpl::GetValueNoAlloc](#cmfcfilterchunkvalueimpl__getvaluenoalloc)|Returns non-allocated (internal value) value.|  
|[CMFCFilterChunkValueImpl::IsValid](#cmfcfilterchunkvalueimpl__isvalid)|Checks whether this property value is valid or not.|  
|[CMFCFilterChunkValueImpl::SetBoolValue](#cmfcfilterchunkvalueimpl__setboolvalue)|Overloaded. Sets the property by key to a Boolean.|  
|[CMFCFilterChunkValueImpl::SetDwordValue](#cmfcfilterchunkvalueimpl__setdwordvalue)|Sets the property by key to a DWORD.|  
|[CMFCFilterChunkValueImpl::SetFileTimeValue](#cmfcfilterchunkvalueimpl__setfiletimevalue)|Sets the property by key to a filetime.|  
|[CMFCFilterChunkValueImpl::SetInt64Value](#cmfcfilterchunkvalueimpl__setint64value)|Sets the property by key to an int64.|  
|[CMFCFilterChunkValueImpl::SetIntValue](#cmfcfilterchunkvalueimpl__setintvalue)|Sets the property by key to an int.|  
|[CMFCFilterChunkValueImpl::SetLongValue](#cmfcfilterchunkvalueimpl__setlongvalue)|Sets the property by key to a LONG.|  
|[CMFCFilterChunkValueImpl::SetSystemTimeValue](#cmfcfilterchunkvalueimpl__setsystemtimevalue)|Sets the property by key to a SystemTime.|  
|[CMFCFilterChunkValueImpl::SetTextValue](#cmfcfilterchunkvalueimpl__settextvalue)|Sets the property by key to a Unicode string.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCFilterChunkValueImpl::SetChunk](#cmfcfilterchunkvalueimpl__setchunk)|A helper function that sets the chunk's common properties.|  
  
## Remarks  
 To use, you simply create a CMFCFilterChunkValueImpl class of the right kind  
  
 Example:  
  
 CMFCFilterChunkValueImpl chunk;  
  
 hr = chunk.SetBoolValue(PKEY_IsAttachment, true);  
  
 or  
  
 hr = chunk.SetFileTimeValue(PKEY_ItemDate, ftLastModified);  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 [CMFCFilterChunkValueImpl](../vs140/cmfcfilterchunkvalueimpl-class.md)  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cmfcfilterchunkvalueimpl__clear">\</a>  CMFCFilterChunkValueImpl::Clear  
 Clears the ChunkValue.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__cmfcfilterchunkvalueimpl">\</a>  CMFCFilterChunkValueImpl::CMFCFilterChunkValueImpl  
 Constructs the object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl___dtorcmfcfilterchunkvalueimpl">\</a>  CMFCFilterChunkValueImpl::~CMFCFilterChunkValueImpl  
 Destructs the object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__copychunk">\</a>  CMFCFilterChunkValueImpl::CopyChunk  
 Copies this chunk to a structure describing the characteristics of a chunk.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to destination value describing the characteristics of the chunk.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__copyfrom">\</a>  CMFCFilterChunkValueImpl::CopyFrom  
 Initializes this chunk value from the other value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies the source value to copy from.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__getchunkguid">\</a>  CMFCFilterChunkValueImpl::GetChunkGUID  
 Retrieves the chunk GUID.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a GUID identifying the chunk.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__getchunkpid">\</a>  CMFCFilterChunkValueImpl::GetChunkPID  
 Retrieves the chunk PID (property ID).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A DWORD value containing the property ID.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__getchunktype">\</a>  CMFCFilterChunkValueImpl::GetChunkType  
 Retrieves the chunk type.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A CHUNKSTATE enumerated value, which specifies whether the current chunk is a text-type property or a value-type property.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__getstring">\</a>  CMFCFilterChunkValueImpl::GetString  
 Retrieves the string value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A string containing the chunk value.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__getvalue">\</a>  CMFCFilterChunkValueImpl::GetValue  
 Retrieves the value as an allocated propvariant.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 When the function returns, this parameter contains the chunk value.  
  
### Return Value  
 S_OK if PROPVARIANT was allocated successfully and the chunk value was successfully copied to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__getvaluenoalloc">\</a>  CMFCFilterChunkValueImpl::GetValueNoAlloc  
 Returns the non-allocated (internal value) value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current chunk value.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__isvalid">\</a>  CMFCFilterChunkValueImpl::IsValid  
 Checks whether this property value is valid or not.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the current chunk value is valid; otherwise <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setboolvalue">\</a>  CMFCFilterChunkValueImpl::SetBoolValue  
 Overloaded. Sets the property by key to a Boolean.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setchunk">\</a>  CMFCFilterChunkValueImpl::SetChunk  
 A helper function that sets the chunk's common properties.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setdwordvalue">\</a>  CMFCFilterChunkValueImpl::SetDwordValue  
 Set the property by key to a DWORD.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setfiletimevalue">\</a>  CMFCFilterChunkValueImpl::SetFileTimeValue  
 Set the property by key to a filetime.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setint64value">\</a>  CMFCFilterChunkValueImpl::SetInt64Value  
 Set the property by key to an int64.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setintvalue">\</a>  CMFCFilterChunkValueImpl::SetIntValue  
 Set the property by key to an int.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setlongvalue">\</a>  CMFCFilterChunkValueImpl::SetLongValue  
 Set the property by key to a LONG.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__setsystemtimevalue">\</a>  CMFCFilterChunkValueImpl::SetSystemTimeValue  
 Sets the property by key to a SystemTime.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
##  \<a name="cmfcfilterchunkvalueimpl__settextvalue">\</a>  CMFCFilterChunkValueImpl::SetTextValue  
 Sets the property by key to a Unicode string.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Specifies a property key.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Specifies the chunk value to set.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Flags indicate whether this chunk contains a text-type or a value-type property. Flag values are taken from the CHUNKSTATE enumeration.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The language and sublanguage associated with a chunk of text. Chunk locale is used by document indexers to perform proper word breaking of text. If the chunk is neither text-type nor a value-type with data type VT_LPWSTR, VT_LPSTR, or VT_BSTR, this field is ignored.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The length in characters of the source text from which the current chunk was derived. A zero value signifies character-by-character correspondence between the source text and the derived text. A nonzero value means that no such direct correspondence exists.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The offset from which the source text for a derived chunk starts in the source chunk.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The type of break that separates the previous chunk from the current chunk. Values are from the CHUNK_BREAKTYPE enumeration.  
  
### Return Value  
 S_OK if successful; otherwise an error code.  
  
### Remarks  
  
## See Also  
 [Classes](../vs140/mfc-classes.md)