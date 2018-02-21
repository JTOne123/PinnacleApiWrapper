﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v11.13.2.0 (NJsonSchema v9.10.21.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace PinnacleApiWrapper
{
    #pragma warning disable // Disable all warnings
    
    public partial class PinnacleWrapper 
    {
   
        /// <summary>Get Client Balance - v1</summary>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<ClientBalanceResponse> GetAsync()
        {
            return GetAsync(System.Threading.CancellationToken.None);
        }
    
        /// <summary>Get Client Balance - v1</summary>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<ClientBalanceResponse> GetAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/client/balance");
    
            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ClientBalanceResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientBalanceResponse>(responseData_, _settings.Value);
                                return result_; 
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ErrorResponse>("BadRequest", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ == "401") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ErrorResponse>("Unauthorized", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ == "403") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ErrorResponse>("Forbidden", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ExtendedErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ExtendedErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ExtendedErrorResponse>("InternalServerError", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
                        }
            
                        return default(ClientBalanceResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }
    
        /// <summary>Get Translations - v1</summary>
        /// <param name="cultureCodes">Must be in Language Culture Name format.</param>
        /// <param name="baseTexts">Array of strings to be translated.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<TranslationResponse> GetAsync(string cultureCodes, string baseTexts)
        {
            return GetAsync(cultureCodes, baseTexts, System.Threading.CancellationToken.None);
        }
    
        /// <summary>Get Translations - v1</summary>
        /// <param name="cultureCodes">Must be in Language Culture Name format.</param>
        /// <param name="baseTexts">Array of strings to be translated.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<TranslationResponse> GetAsync(string cultureCodes, string baseTexts, System.Threading.CancellationToken cancellationToken)
        {
            if (cultureCodes == null)
                throw new System.ArgumentNullException("cultureCodes");
    
            if (baseTexts == null)
                throw new System.ArgumentNullException("baseTexts");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v1/translations?");
            urlBuilder_.Append("cultureCodes=").Append(System.Uri.EscapeDataString(ConvertToString(cultureCodes, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Append("baseTexts=").Append(System.Uri.EscapeDataString(ConvertToString(baseTexts, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;
    
            var client_ = new System.Net.Http.HttpClient();
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(TranslationResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<TranslationResponse>(responseData_, _settings.Value);
                                return result_; 
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ErrorResponse>("BadRequest", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ == "401") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ErrorResponse>("Unauthorized", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ == "403") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ErrorResponse>("Forbidden", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ == "500") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(ExtendedErrorResponse); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ExtendedErrorResponse>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<ExtendedErrorResponse>("InternalServerError", status_, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
                        }
            
                        return default(TranslationResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }
    
    }

    /// <summary>Client Balance Details</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ClientBalanceResponse : System.ComponentModel.INotifyPropertyChanged
    {
        private double _availableBalance;
        private double _outstandingTransactions;
        private double _givenCredit;
        private string _currency;
    
        /// <summary>Amount available for betting.</summary>
        [Newtonsoft.Json.JsonProperty("availableBalance", Required = Newtonsoft.Json.Required.Always)]
        public double AvailableBalance
        {
            get { return _availableBalance; }
            set 
            {
                if (_availableBalance != value)
                {
                    _availableBalance = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Sum of not yet settled bet amounts.</summary>
        [Newtonsoft.Json.JsonProperty("outstandingTransactions", Required = Newtonsoft.Json.Required.Always)]
        public double OutstandingTransactions
        {
            get { return _outstandingTransactions; }
            set 
            {
                if (_outstandingTransactions != value)
                {
                    _outstandingTransactions = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Client’s credit.</summary>
        [Newtonsoft.Json.JsonProperty("givenCredit", Required = Newtonsoft.Json.Required.Always)]
        public double GivenCredit
        {
            get { return _givenCredit; }
            set 
            {
                if (_givenCredit != value)
                {
                    _givenCredit = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Client’s currency code.</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Currency
        {
            get { return _currency; }
            set 
            {
                if (_currency != value)
                {
                    _currency = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static ClientBalanceResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ClientBalanceResponse>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TranslationResponse : System.ComponentModel.INotifyPropertyChanged
    {
        private System.Collections.ObjectModel.ObservableCollection<Translation> _translations;
    
        /// <summary>Collection of translations.</summary>
        [Newtonsoft.Json.JsonProperty("translations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Translation> Translations
        {
            get { return _translations; }
            set 
            {
                if (_translations != value)
                {
                    _translations = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static TranslationResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TranslationResponse>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Translation : System.ComponentModel.INotifyPropertyChanged
    {
        private string _text;
        private System.Collections.ObjectModel.ObservableCollection<TranslationByCulture> _cultures;
    
        /// <summary>Original requested text to be translated.</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text != value)
                {
                    _text = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Collection of translations by culture.</summary>
        [Newtonsoft.Json.JsonProperty("cultures", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<TranslationByCulture> Cultures
        {
            get { return _cultures; }
            set 
            {
                if (_cultures != value)
                {
                    _cultures = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Translation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Translation>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.10.21.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TranslationByCulture : System.ComponentModel.INotifyPropertyChanged
    {
        private string _id;
        private string _text;
    
        /// <summary>Culture based on which the text is translated.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id
        {
            get { return _id; }
            set 
            {
                if (_id != value)
                {
                    _id = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>Translation text.</summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text != value)
                {
                    _text = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static TranslationByCulture FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TranslationByCulture>(data);
        }
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }

}