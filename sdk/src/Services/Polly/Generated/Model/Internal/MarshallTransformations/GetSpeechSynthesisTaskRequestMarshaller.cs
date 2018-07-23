/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Polly.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSpeechSynthesisTask Request Marshaller
    /// </summary>       
    public class GetSpeechSynthesisTaskRequestMarshaller : IMarshaller<IRequest, GetSpeechSynthesisTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSpeechSynthesisTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSpeechSynthesisTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Polly");
            request.HttpMethod = "GET";

            string uriResourcePath = "/v1/synthesisTasks/{TaskId}";
            if (!publicRequest.IsSetTaskId())
                throw new AmazonPollyException("Request object does not have required field TaskId set");
            uriResourcePath = uriResourcePath.Replace("{TaskId}", StringUtils.FromString(publicRequest.TaskId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static GetSpeechSynthesisTaskRequestMarshaller _instance = new GetSpeechSynthesisTaskRequestMarshaller();        

        internal static GetSpeechSynthesisTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSpeechSynthesisTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}