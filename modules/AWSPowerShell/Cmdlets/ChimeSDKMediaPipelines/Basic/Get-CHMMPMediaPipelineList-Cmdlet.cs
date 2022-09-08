/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.ChimeSDKMediaPipelines;
using Amazon.ChimeSDKMediaPipelines.Model;

namespace Amazon.PowerShell.Cmdlets.CHMMP
{
    /// <summary>
    /// Returns a list of media pipelines.
    /// </summary>
    [Cmdlet("Get", "CHMMPMediaPipelineList")]
    [OutputType("Amazon.ChimeSDKMediaPipelines.Model.MediaPipelineSummary")]
    [AWSCmdlet("Calls the Amazon Chime SDK Media Pipelines ListMediaPipelines API operation.", Operation = new[] {"ListMediaPipelines"}, SelectReturnType = typeof(Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse))]
    [AWSCmdletOutput("Amazon.ChimeSDKMediaPipelines.Model.MediaPipelineSummary or Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse",
        "This cmdlet returns a collection of Amazon.ChimeSDKMediaPipelines.Model.MediaPipelineSummary objects.",
        "The service call response (type Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetCHMMPMediaPipelineListCmdlet : AmazonChimeSDKMediaPipelinesClientCmdlet, IExecutor
    {
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of results to return in a single call. Valid Range: 1 - 99.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>The token used to retrieve the next page of results.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'MediaPipelines'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse).
        /// Specifying the name of a property of type Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "MediaPipelines";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse, GetCHMMPMediaPipelineListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesRequest();
            
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse CallAWSServiceOperation(IAmazonChimeSDKMediaPipelines client, Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Chime SDK Media Pipelines", "ListMediaPipelines");
            try
            {
                #if DESKTOP
                return client.ListMediaPipelines(request);
                #elif CORECLR
                return client.ListMediaPipelinesAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.ChimeSDKMediaPipelines.Model.ListMediaPipelinesResponse, GetCHMMPMediaPipelineListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.MediaPipelines;
        }
        
    }
}