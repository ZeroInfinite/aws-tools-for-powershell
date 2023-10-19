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
using Amazon.Neptunedata;
using Amazon.Neptunedata.Model;

namespace Amazon.PowerShell.Cmdlets.NEPT
{
    /// <summary>
    /// Creates a new Neptune ML inference endpoint that lets you query one specific model
    /// that the model-training process constructed. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
    /// inference endpoints using the endpoints command</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#createmlendpoint">neptune-db:CreateMLEndpoint</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    [Cmdlet("New", "NEPTMLEndpoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Neptunedata.Model.CreateMLEndpointResponse")]
    [AWSCmdlet("Calls the Amazon NeptuneData CreateMLEndpoint API operation.", Operation = new[] {"CreateMLEndpoint"}, SelectReturnType = typeof(Amazon.Neptunedata.Model.CreateMLEndpointResponse))]
    [AWSCmdletOutput("Amazon.Neptunedata.Model.CreateMLEndpointResponse",
        "This cmdlet returns an Amazon.Neptunedata.Model.CreateMLEndpointResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewNEPTMLEndpointCmdlet : AmazonNeptunedataClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter Id
        /// <summary>
        /// <para>
        /// <para>A unique identifier for the new inference endpoint. The default is an autogenerated
        /// timestamped name.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String Id { get; set; }
        #endregion
        
        #region Parameter InstanceCount
        /// <summary>
        /// <para>
        /// <para>The minimum number of Amazon EC2 instances to deploy to an endpoint for prediction.
        /// The default is 1</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? InstanceCount { get; set; }
        #endregion
        
        #region Parameter InstanceType
        /// <summary>
        /// <para>
        /// <para>The type of Neptune ML instance to use for online servicing. The default is <code>ml.m5.xlarge</code>.
        /// Choosing the ML instance for an inference endpoint depends on the task type, the graph
        /// size, and your budget.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String InstanceType { get; set; }
        #endregion
        
        #region Parameter MlModelTrainingJobId
        /// <summary>
        /// <para>
        /// <para>The job Id of the completed model-training job that has created the model that the
        /// inference endpoint will point to. You must supply either the <code>mlModelTrainingJobId</code>
        /// or the <code>mlModelTransformJobId</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MlModelTrainingJobId { get; set; }
        #endregion
        
        #region Parameter MlModelTransformJobId
        /// <summary>
        /// <para>
        /// <para>The job Id of the completed model-transform job. You must supply either the <code>mlModelTrainingJobId</code>
        /// or the <code>mlModelTransformJobId</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String MlModelTransformJobId { get; set; }
        #endregion
        
        #region Parameter ModelName
        /// <summary>
        /// <para>
        /// <para>Model type for training. By default the Neptune ML model is automatically based on
        /// the <code>modelType</code> used in data processing, but you can specify a different
        /// model type here. The default is <code>rgcn</code> for heterogeneous graphs and <code>kge</code>
        /// for knowledge graphs. The only valid value for heterogeneous graphs is <code>rgcn</code>.
        /// Valid values for knowledge graphs are: <code>kge</code>, <code>transe</code>, <code>distmult</code>,
        /// and <code>rotate</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ModelName { get; set; }
        #endregion
        
        #region Parameter NeptuneIamRoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of an IAM role providing Neptune access to SageMaker and Amazon S3 resources.
        /// This must be listed in your DB cluster parameter group or an error will be thrown.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NeptuneIamRoleArn { get; set; }
        #endregion
        
        #region Parameter Update
        /// <summary>
        /// <para>
        /// <para>If set to <code>true</code>, <code>update</code> indicates that this is an update
        /// request. The default is <code>false</code>. You must supply either the <code>mlModelTrainingJobId</code>
        /// or the <code>mlModelTransformJobId</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Update { get; set; }
        #endregion
        
        #region Parameter VolumeEncryptionKMSKey
        /// <summary>
        /// <para>
        /// <para>The Amazon Key Management Service (Amazon KMS) key that SageMaker uses to encrypt
        /// data on the storage volume attached to the ML compute instances that run the training
        /// job. The default is None.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String VolumeEncryptionKMSKey { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Neptunedata.Model.CreateMLEndpointResponse).
        /// Specifying the name of a property of type Amazon.Neptunedata.Model.CreateMLEndpointResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Id parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Id), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-NEPTMLEndpoint (CreateMLEndpoint)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Neptunedata.Model.CreateMLEndpointResponse, NewNEPTMLEndpointCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Id;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Id = this.Id;
            context.InstanceCount = this.InstanceCount;
            context.InstanceType = this.InstanceType;
            context.MlModelTrainingJobId = this.MlModelTrainingJobId;
            context.MlModelTransformJobId = this.MlModelTransformJobId;
            context.ModelName = this.ModelName;
            context.NeptuneIamRoleArn = this.NeptuneIamRoleArn;
            context.Update = this.Update;
            context.VolumeEncryptionKMSKey = this.VolumeEncryptionKMSKey;
            
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
            var request = new Amazon.Neptunedata.Model.CreateMLEndpointRequest();
            
            if (cmdletContext.Id != null)
            {
                request.Id = cmdletContext.Id;
            }
            if (cmdletContext.InstanceCount != null)
            {
                request.InstanceCount = cmdletContext.InstanceCount.Value;
            }
            if (cmdletContext.InstanceType != null)
            {
                request.InstanceType = cmdletContext.InstanceType;
            }
            if (cmdletContext.MlModelTrainingJobId != null)
            {
                request.MlModelTrainingJobId = cmdletContext.MlModelTrainingJobId;
            }
            if (cmdletContext.MlModelTransformJobId != null)
            {
                request.MlModelTransformJobId = cmdletContext.MlModelTransformJobId;
            }
            if (cmdletContext.ModelName != null)
            {
                request.ModelName = cmdletContext.ModelName;
            }
            if (cmdletContext.NeptuneIamRoleArn != null)
            {
                request.NeptuneIamRoleArn = cmdletContext.NeptuneIamRoleArn;
            }
            if (cmdletContext.Update != null)
            {
                request.Update = cmdletContext.Update.Value;
            }
            if (cmdletContext.VolumeEncryptionKMSKey != null)
            {
                request.VolumeEncryptionKMSKey = cmdletContext.VolumeEncryptionKMSKey;
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
        
        private Amazon.Neptunedata.Model.CreateMLEndpointResponse CallAWSServiceOperation(IAmazonNeptunedata client, Amazon.Neptunedata.Model.CreateMLEndpointRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon NeptuneData", "CreateMLEndpoint");
            try
            {
                #if DESKTOP
                return client.CreateMLEndpoint(request);
                #elif CORECLR
                return client.CreateMLEndpointAsync(request).GetAwaiter().GetResult();
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
            public System.String Id { get; set; }
            public System.Int32? InstanceCount { get; set; }
            public System.String InstanceType { get; set; }
            public System.String MlModelTrainingJobId { get; set; }
            public System.String MlModelTransformJobId { get; set; }
            public System.String ModelName { get; set; }
            public System.String NeptuneIamRoleArn { get; set; }
            public System.Boolean? Update { get; set; }
            public System.String VolumeEncryptionKMSKey { get; set; }
            public System.Func<Amazon.Neptunedata.Model.CreateMLEndpointResponse, NewNEPTMLEndpointCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
