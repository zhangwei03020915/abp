using System.Collections.Generic;
using Volo.Abp.Collections;

namespace Volo.Abp.Settings;

public class AbpSettingOptions
{
    public ITypeList<ISettingDefinitionProvider> DefinitionProviders { get; }

    public ITypeList<ISettingValueProvider> ValueProviders { get; }

    public HashSet<string> DeletedSettings { get; }

    /// <summary>
    /// If set to true, returns the original value if the decryption fails. Otherwise, returns null.
    /// </summary>
    public bool ReturnOrginalValueIfDecryptFailed { get; set; }

    public AbpSettingOptions()
    {
        DefinitionProviders = new TypeList<ISettingDefinitionProvider>();
        ValueProviders = new TypeList<ISettingValueProvider>();
        DeletedSettings = new HashSet<string>();
        ReturnOrginalValueIfDecryptFailed = true;
    }
}
