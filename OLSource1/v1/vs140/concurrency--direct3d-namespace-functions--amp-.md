---
title: "Concurrency::direct3d namespace functions (AMP)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 28943b62-52c9-42dc-baf1-ca7b095c1a19
caps.latest.revision: 10
---
# Concurrency::direct3d namespace functions (AMP)
||||  
|-|-|-|  
|[abs Function](#abs_function)|[clamp Function](#clamp_function)|[countbits Function](#countbits_function)|  
|[d3d_access_lock Function](#d3d_access_lock_function)|[d3d_access_try_lock Function](#d3d_access_try_lock_function)|[d3d_access_unlock Function](#d3d_access_unlock_function)|  
|[firstbithigh Function](#firstbithigh_function)|[firstbitlow Function](#firstbitlow_function)|[get_buffer Function](#get_buffer_function)|  
|[imax Function](#imax_function)|[imin Function](#imin_function)|[is_timeout_disabled Function](#is_timeout_disabled_function)|  
|[mad Function](#mad_function)|[make_array Function](#make_array_function)|[noise Function](#noise_function)|  
|[radians Function](#radians_function)|[rcp Function](#rcp_function)|[reversebits Function](#reversebits_function)|  
|[saturate Function](#saturate_function)|[sign Function](#sign_function)|[smoothstep Function](#smoothstep_function)|  
|[step Function](#step_function)|[umax Function](#umax_function)|[umin Function](#umin_function)|  
  
##  \<a name="abs_function">\</a>  abs Function  
 Returns the absolute value of the argument  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 Returns the absolute value of the argument.  
  
##  \<a name="clamp_function">\</a>  clamp Function  
 Computes the value of the first specified argument clamped to a range defined by the second and third specified arguments.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The value to be clamped  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The lower bound of the clamping range.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The upper bound of the clamping range.  
  
### Return Value  
 The clamped value of                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
##  \<a name="countbits_function">\</a>  countbits Function  
 Counts the number of set bits in _X  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Unsigned integer value  
  
### Return Value  
 Returns the number of set bits in _X  
  
##  \<a name="d3d_access_lock_function">\</a>  d3d_access_lock Function  
 Acquire a lock on an accelerator_view for the purpose of safely performing D3D operations on resources shared with the accelerator_view. The accelerator_view and all C++ AMP resources associated with this accelerator_view internally take this lock when performing operations and will block while another thread holds the D3D access lock. This lock is non-recursive: It is undefined behavior to call this function from a thread that already holds the lock. It is undefined behavior to perform operations on the accelerator_view or any data container associated with the accelerator_view from the thread that holds the D3D access lock. See also scoped_d3d_access_lock, a RAII-style class for a scope-based D3D access lock.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The accelerator_view to lock.  
  
##  \<a name="d3d_access_try_lock_function">\</a>  d3d_access_try_lock Function  
 Attempt to acquire the D3D access lock on an accelerator_view without blocking.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The accelerator_view to lock.  
  
### Return Value  
 true if the lock was acquired, or false if it is currently held by another thread.  
  
##  \<a name="d3d_access_unlock_function">\</a>  d3d_access_unlock Function  
 Release the D3D access lock on the given accelerator_view. If the calling thread does not hold the lock on the accelerator_view the results are undefined.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The accelerator_view for which the lock is to be released.  
  
##  \<a name="firstbithigh_function">\</a>  firstbithigh Function  
 Gets the location of the first set bit in _X, beginning with the highest-order bit and moving towards the lowest-order bit.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 The location of the first set bit  
  
##  \<a name="firstbitlow_function">\</a>  firstbitlow Function  
 Gets the location of the first set bit in _X, beginning with the lowest-order bit and working toward the highest-order bit.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 Returns The location of the first set bit  
  
##  \<a name="get_buffer_function">\</a>  get_buffer Function  
 Get the Direct3D buffer interface underlying the specified array.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The type of elements in the array.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The rank of the array.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An array on a Direct3D accelerator_view for which the underlying Direct3D buffer interface is returned.  
  
### Return Value  
 The IUnknown interface pointer corresponding to the Direct3D buffer underlying the array.  
  
##  \<a name="imax_function">\</a>  imax Function  
 Determine the maximum numeric value of the arguments  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Integer value  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 Return the maximum numeric value of the arguments  
  
##  \<a name="imin_function">\</a>  imin Function  
 Determine the minimum numeric value of the arguments  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Integer value  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 Return the minimum numeric value of the arguments  
  
##  \<a name="is_timeout_disabled_function">\</a>  is_timeout_disabled Function  
 Returns a boolean flag indicating if timeout is disabled for the specified accelerator_view. This corresponds to the D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT flag for Direct3D device creation.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The accelerator_view for which the timeout disabled setting is to be queried.  
  
### Return Value  
 A boolean flag indicating if timeout is disabled for the specified accelerator_view.  
  
##  \<a name="mad_function">\</a>  mad Function  
 Computes the product of the first and second specified argument, then adds the third specified argument.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The first specified argument.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The second specified argument.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The third specified argument.  
  
### Return Value  
 The result of                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> *                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> +                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="make_array_function">\</a>  make_array Function  
 Create an array from a Direct3D buffer interface pointer.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The element type of the array to be created.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The rank of the array to be created.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An extent that describes the shape of the array aggregate.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A D3D accelerator view on which the array is to be created.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 IUnknown interface pointer of the D3D buffer to create the array from.  
  
### Return Value  
 An array created using the provided Direct3D buffer.  
  
##  \<a name="noise_function">\</a>  noise Function  
 Generates a random value using the Perlin noise algorithm  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Floating-point value from which to generate Perlin noise  
  
### Return Value  
 Returns The Perlin noise value within a range between -1 and 1  
  
##  \<a name="radians_function">\</a>  radians Function  
 Converts _X from degrees to radians  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Floating-point value  
  
### Return Value  
 Returns _X converted from degrees to radians  
  
##  \<a name="rcp_function">\</a>  rcp Function  
 Computes the reciprocal of the specified argument by using a fast approximation.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The value for which to compute the reciprocal.  
  
### Return Value  
 The reciprocal of the specified argument.  
  
##  \<a name="reversebits_function">\</a>  reversebits Function  
 Reverses the order of the bits in _X  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Unsigned integer value  
  
### Return Value  
 Returns the value with the bit order reversed in _X  
  
##  \<a name="saturate_function">\</a>  saturate Function  
 Clamps _X within the range of 0 to 1  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Floating-point value  
  
### Return Value  
 Returns _X clamped within the range of 0 to 1  
  
##  \<a name="sign_function">\</a>  sign Function  
 Determines the sign of the specified argument.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 The sign of the argument.  
  
##  \<a name="smoothstep_function">\</a>  smoothstep Function  
 Returns a smooth Hermite interpolation between 0 and 1, if _X is in the range [_Min, _Max].  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Floating-point value  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Floating-point value  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Floating-point value  
  
### Return Value  
 Returns 0 if _X is less than _Min; 1 if _X is greater than _Max; otherwise, a value between 0 and 1 if _X is in the range [_Min, _Max]  
  
##  \<a name="step_function">\</a>  step Function  
 Compares two values, returning 0 or 1 based on which value is greater  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Floating-point value  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Floating-point value  
  
### Return Value  
 Returns 1 if the _X is greater than or equal to _Y; otherwise, 0  
  
##  \<a name="umax_function">\</a>  umax Function  
 Determine the maximum numeric value of the arguments  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Integer value  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 Return the maximum numeric value of the arguments  
  
##  \<a name="umin_function">\</a>  umin Function  
 Determine the minimum numeric value of the arguments  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Integer value  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Integer value  
  
### Return Value  
 Return the minimum numeric value of the arguments  
  
## See Also  
 [Concurrency::direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)