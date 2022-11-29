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
using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;

namespace Amazon.PowerShell.Cmdlets.KMS
{
    /// <summary>
    /// Verifies a digital signature that was generated by the <a>Sign</a> operation. 
    /// 
    ///   
    /// <para>
    /// Verification confirms that an authorized user signed the message with the specified
    /// KMS key and signing algorithm, and the message hasn't changed since it was signed.
    /// If the signature is verified, the value of the <code>SignatureValid</code> field in
    /// the response is <code>True</code>. If the signature verification fails, the <code>Verify</code>
    /// operation fails with an <code>KMSInvalidSignatureException</code> exception.
    /// </para><para>
    /// A digital signature is generated by using the private key in an asymmetric KMS key.
    /// The signature is verified by using the public key in the same asymmetric KMS key.
    /// For information about asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
    /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para><para>
    /// To verify a digital signature, you can use the <code>Verify</code> operation. Specify
    /// the same asymmetric KMS key, message, and signing algorithm that were used to produce
    /// the signature.
    /// </para><para>
    /// You can also verify the digital signature by using the public key of the KMS key outside
    /// of KMS. Use the <a>GetPublicKey</a> operation to download the public key in the asymmetric
    /// KMS key and then use the public key to verify the signature outside of KMS. The advantage
    /// of using the <code>Verify</code> operation is that it is performed within KMS. As
    /// a result, it's easy to call, the operation is performed within the FIPS boundary,
    /// it is logged in CloudTrail, and you can use key policy and IAM policy to determine
    /// who is authorized to use the KMS key to verify signatures.
    /// </para><para>
    /// To verify a signature outside of KMS with an SM2 public key (China Regions only),
    /// you must specify the distinguishing ID. By default, KMS uses <code>1234567812345678</code>
    /// as the distinguishing ID. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/asymmetric-key-specs.html#key-spec-sm-offline-verification">Offline
    /// verification with SM2 key pairs</a>.
    /// </para><para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para><para><b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
    /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
    /// <code>KeyId</code> parameter. 
    /// </para><para><b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Verify</a>
    /// (key policy)
    /// </para><para><b>Related operations</b>: <a>Sign</a></para>
    /// </summary>
    [Cmdlet("Test", "KMSSignature")]
    [OutputType("System.Boolean")]
    [AWSCmdlet("Calls the AWS Key Management Service Verify API operation.", Operation = new[] {"Verify"}, SelectReturnType = typeof(Amazon.KeyManagementService.Model.VerifyResponse))]
    [AWSCmdletOutput("System.Boolean or Amazon.KeyManagementService.Model.VerifyResponse",
        "This cmdlet returns a System.Boolean object.",
        "The service call response (type Amazon.KeyManagementService.Model.VerifyResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class TestKMSSignatureCmdlet : AmazonKeyManagementServiceClientCmdlet, IExecutor
    {
        
        #region Parameter GrantToken
        /// <summary>
        /// <para>
        /// <para>A list of grant tokens.</para><para>Use a grant token when your permission to call this operation comes from a new grant
        /// that has not yet achieved <i>eventual consistency</i>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("GrantTokens")]
        public System.String[] GrantToken { get; set; }
        #endregion
        
        #region Parameter KeyId
        /// <summary>
        /// <para>
        /// <para>Identifies the asymmetric KMS key that will be used to verify the signature. This
        /// must be the same KMS key that was used to generate the signature. If you specify a
        /// different KMS key, the signature verification fails.</para><para>To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using
        /// an alias name, prefix it with <code>"alias/"</code>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.</para><para>For example:</para><ul><li><para>Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code></para></li><li><para>Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code></para></li><li><para>Alias name: <code>alias/ExampleAlias</code></para></li><li><para>Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code></para></li></ul><para>To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String KeyId { get; set; }
        #endregion
        
        #region Parameter Message
        /// <summary>
        /// <para>
        /// <para>Specifies the message that was signed. You can submit a raw message of up to 4096
        /// bytes, or a hash digest of the message. If you submit a digest, use the <code>MessageType</code>
        /// parameter with a value of <code>DIGEST</code>.</para><para>If the message specified here is different from the message that was signed, the signature
        /// verification fails. A message and its hash digest are considered to be the same message.</para>
        /// </para>
        /// <para>The cmdlet will automatically convert the supplied parameter of type string, string[], System.IO.FileInfo or System.IO.Stream to byte[] before supplying it to the service.</para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Amazon.PowerShell.Common.MemoryStreamParameterConverter]
        public byte[] Message { get; set; }
        #endregion
        
        #region Parameter MessageType
        /// <summary>
        /// <para>
        /// <para>Tells KMS whether the value of the <code>Message</code> parameter is a message or
        /// message digest. The default value, RAW, indicates a message. To indicate a message
        /// digest, enter <code>DIGEST</code>.</para><important><para>Use the <code>DIGEST</code> value only when the value of the <code>Message</code>
        /// parameter is a message digest. If you use the <code>DIGEST</code> value with a raw
        /// message, the security of the verification operation can be compromised.</para></important>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.KeyManagementService.MessageType")]
        public Amazon.KeyManagementService.MessageType MessageType { get; set; }
        #endregion
        
        #region Parameter Signature
        /// <summary>
        /// <para>
        /// <para>The signature that the <code>Sign</code> operation generated.</para>
        /// </para>
        /// <para>The cmdlet will automatically convert the supplied parameter of type string, string[], System.IO.FileInfo or System.IO.Stream to byte[] before supplying it to the service.</para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Amazon.PowerShell.Common.MemoryStreamParameterConverter]
        public byte[] Signature { get; set; }
        #endregion
        
        #region Parameter SigningAlgorithm
        /// <summary>
        /// <para>
        /// <para>The signing algorithm that was used to sign the message. If you submit a different
        /// algorithm, the signature verification fails.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.KeyManagementService.SigningAlgorithmSpec")]
        public Amazon.KeyManagementService.SigningAlgorithmSpec SigningAlgorithm { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SignatureValid'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.KeyManagementService.Model.VerifyResponse).
        /// Specifying the name of a property of type Amazon.KeyManagementService.Model.VerifyResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SignatureValid";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Message parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Message' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Message' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.KeyManagementService.Model.VerifyResponse, TestKMSSignatureCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Message;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.GrantToken != null)
            {
                context.GrantToken = new List<System.String>(this.GrantToken);
            }
            context.KeyId = this.KeyId;
            #if MODULAR
            if (this.KeyId == null && ParameterWasBound(nameof(this.KeyId)))
            {
                WriteWarning("You are passing $null as a value for parameter KeyId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Message = this.Message;
            #if MODULAR
            if (this.Message == null && ParameterWasBound(nameof(this.Message)))
            {
                WriteWarning("You are passing $null as a value for parameter Message which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MessageType = this.MessageType;
            context.Signature = this.Signature;
            #if MODULAR
            if (this.Signature == null && ParameterWasBound(nameof(this.Signature)))
            {
                WriteWarning("You are passing $null as a value for parameter Signature which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SigningAlgorithm = this.SigningAlgorithm;
            #if MODULAR
            if (this.SigningAlgorithm == null && ParameterWasBound(nameof(this.SigningAlgorithm)))
            {
                WriteWarning("You are passing $null as a value for parameter SigningAlgorithm which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            System.IO.MemoryStream _MessageStream = null;
            System.IO.MemoryStream _SignatureStream = null;
            
            try
            {
                var cmdletContext = context as CmdletContext;
                // create request
                var request = new Amazon.KeyManagementService.Model.VerifyRequest();
                
                if (cmdletContext.GrantToken != null)
                {
                    request.GrantTokens = cmdletContext.GrantToken;
                }
                if (cmdletContext.KeyId != null)
                {
                    request.KeyId = cmdletContext.KeyId;
                }
                if (cmdletContext.Message != null)
                {
                    _MessageStream = new System.IO.MemoryStream(cmdletContext.Message);
                    request.Message = _MessageStream;
                }
                if (cmdletContext.MessageType != null)
                {
                    request.MessageType = cmdletContext.MessageType;
                }
                if (cmdletContext.Signature != null)
                {
                    _SignatureStream = new System.IO.MemoryStream(cmdletContext.Signature);
                    request.Signature = _SignatureStream;
                }
                if (cmdletContext.SigningAlgorithm != null)
                {
                    request.SigningAlgorithm = cmdletContext.SigningAlgorithm;
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
            finally
            {
                if( _MessageStream != null)
                {
                    _MessageStream.Dispose();
                }
                if( _SignatureStream != null)
                {
                    _SignatureStream.Dispose();
                }
            }
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.KeyManagementService.Model.VerifyResponse CallAWSServiceOperation(IAmazonKeyManagementService client, Amazon.KeyManagementService.Model.VerifyRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Key Management Service", "Verify");
            try
            {
                #if DESKTOP
                return client.Verify(request);
                #elif CORECLR
                return client.VerifyAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> GrantToken { get; set; }
            public System.String KeyId { get; set; }
            public byte[] Message { get; set; }
            public Amazon.KeyManagementService.MessageType MessageType { get; set; }
            public byte[] Signature { get; set; }
            public Amazon.KeyManagementService.SigningAlgorithmSpec SigningAlgorithm { get; set; }
            public System.Func<Amazon.KeyManagementService.Model.VerifyResponse, TestKMSSignatureCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SignatureValid;
        }
        
    }
}
