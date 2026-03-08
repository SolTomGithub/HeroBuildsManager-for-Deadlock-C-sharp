using System;
using System.Collections.Generic;
using System.Text;

namespace ProtobufDecodeTestDeadlock.Models.ItemDeps
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
	public class AbilityCastDelay
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class AbilityCastRange
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class AbilityChannelTime
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class AbilityCharges
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class AbilityChargeUpTime
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public string icon { get; set; }
	}

	public class AbilityCooldown
	{
		public object value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class AbilityCooldownBetweenCharge
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class AbilityDuration
	{
		public object value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
		public string street_brawl_value { get; set; }
	}

	public class AbilityLifestealPercentHero
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AbilityLifestealPercentHeroPassive
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AbilityPostCastDuration
	{
		public string value { get; set; }
		public string disable_value { get; set; }
	}

	public class AbilityResourceCost
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string disable_value { get; set; }
		public string icon { get; set; }
	}

	public class AbilityUnitTargetLimit
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
	}

	public class ActivatedFireRate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ActivateTime
	{
		public string value { get; set; }
	}

	public class ActiveBonusFireRate
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ActiveBonusLifesteal
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ActiveBonusMoveSpeed
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ActiveMoveSpeedPenalty
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public bool negative_attribute { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ActiveRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ActiveReloadPercent
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AirBonusDamageGiven
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AirBonusDamageTaken
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AirControlAccelPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class AirControlPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class AirJumps
	{
		public string value { get; set; }
	}

	public class AirJumpVerticalSpeedPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class AirMoveIncreasePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AllyPercentage
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AmbushBonusFireRate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AmbushBonusMeleeDamage
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AmbushBonusTechPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AmbushDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AmmoPerSoul
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AmmoReloadPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ArmingTime
	{
		public string value { get; set; }
	}

	public class ArmorLossPerHit
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class AssaultDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class AssaultFireRate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
	}

	public class AssaultLifestealPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
	}

	public class AttackConeAngle
	{
		public string value { get; set; }
	}

	public class AuraRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BarrierDuration
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BaseAttackDamagePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string disable_value { get; set; }
	}

	public class BaseAttackDamagePercentAtMaxDuration
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BaseAttackDamagePercentBonus
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BaseBonusCounter
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class BaseBonusWeaponPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BaseDamagePct
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BaseDamagePerShot
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
	}

	public class BeamLength
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class BeamWidth
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class BonusAbilityCharges
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class BonusAbilityChargesNonCharge
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusAbilityDurationPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class BonusAttackRangePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusBaseHealth
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusBuffsPerGold
	{
		public string value { get; set; }
	}

	public class BonusBulletSpeedPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public bool? negative_attribute { get; set; }
	}

	public class BonusChargedAbilityDamage
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
	}

	public class BonusChargedCooldownReduction
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class BonusClipPerKill
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
	}

	public class BonusClipSize
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string icon { get; set; }
	}

	public class BonusClipSizePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusDamagePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusDamagePerHero
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusFireRate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class BonusFireRateNPC
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusGoldPerMinute
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusHeadshotDamage
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class BonusHealth
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusHealthRegen
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class BonusHeavyMeleeDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusMeleeDamagePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusMoveSpeed
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public bool? negative_attribute { get; set; }
		public string display_units { get; set; }
		public string loc_token_override { get; set; }
	}

	public class BonusMovespeed2
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusPerChain
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class BonusReloadSpeed
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusReloadTime
	{
		public string value { get; set; }
		public string postfix { get; set; }
	}

	public class BonusShotsDuration
	{
		public string value { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusSoulsPct
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class BonusSpirit
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string conditional { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class BonusSpiritForChargedAbilities
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusSpiritMaxTime
	{
		public string value { get; set; }
	}

	public class BonusSpiritMin
	{
		public string value { get; set; }
	}

	public class BonusSpiritWindow
	{
		public string value { get; set; }
	}

	public class BonusSprintSpeed
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string provided_property_type { get; set; }
	}

	public class BonusWeaponPower
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BonusZoomPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuffBulletResist
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuffDamageMult
	{
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuffDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuffFrequency
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuffMoveSpeedBonus
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuffTechResist
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BuildUpDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class BuildUpPerShot
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletArmor
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletArmorReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public ScaleFunction scale_function { get; set; }
	}

	public class BulletDamageReflectedPct
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletLifestealPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class BulletProcDeflectionPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletRadius
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletResist
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletResistBelowThreshold
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletResistDuration
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletResistPerStack
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletResistReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletsBonusMagicDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletShieldDamagePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletShieldMaxHealth
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BulletSpeedOverride
	{
		public string value { get; set; }
	}

	public class BulletSplitShot
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class BurstFireShotPercent
	{
		public string value { get; set; }
	}

	public class BurstFireShotsFromClipPercent
	{
		public string value { get; set; }
		public string postfix { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CaptureRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CasterBuffDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class CasterHealthPercent
	{
		public string value { get; set; }
		public string postfix { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ChainCount
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ChainRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ChainTickRate
	{
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class ChannelMoveSpeed
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public string provided_property_type { get; set; }
	}

	public class CloseRangeBonusDamageRange
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CloseRangeBonusWeaponPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string conditional { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CombatBarrier
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string provided_property_type { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class CooldownBetweenChargeReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CooldownOnMiss
	{
		public double value { get; set; }
	}

	public class CooldownReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class CooldownReductionFlat
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CooldownReductionOnChargedAbilities
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CooldownReductionOnHitMin
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CooldownReductionOnHitPct
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CooldownReductionPctOnNonHeroes
	{
		public string value { get; set; }
	}

	public class CooldownReductionPctOnOthers
	{
		public string value { get; set; }
	}

	public class CooldownReductionPerHit
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CritDamagePercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class CurrentHealthDamage
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class CycleTimeFireRateDecrease
	{
		public string value { get; set; }
	}

	public class Damage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string loc_token_override { get; set; }
	}

	public class DamageDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DamageHeight
	{
		public string value { get; set; }
	}

	public class DamagePctVsNonHeroes
	{
		public string value { get; set; }
	}

	public class DamagePerChain
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DamagePulseAmount
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public ScaleFunction scale_function { get; set; }
	}

	public class DamagePulseInterval
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DamagePulseRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DamageReduction
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class DamageThreshold
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public string display_units { get; set; }
	}

	public class DamageThresholdDuration
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class DamageToStack
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DamageWindow
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DampingFactor
	{
		public string value { get; set; }
	}

	public class DazeDuration
	{
		public double value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DazeMoveSpeed
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string icon { get; set; }
	}

	public class DeathImmunityDamageReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public bool negative_attribute { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DeathImmunityDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DebuffDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DebuffRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class DeflectionPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DeflectionRandomness
	{
		public string value { get; set; }
	}

	public class DegenResistance
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DelayBeforeStun
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DelayDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class Description
	{
		public string desc { get; set; }
		public string active { get; set; }
		public string passive { get; set; }
	}

	public class DiminishingMultiplier
	{
		public string value { get; set; }
	}

	public class DotDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DotHealthPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string tooltip_section { get; set; }
	}

	public class DotMultiplerTroopers
	{
		public string value { get; set; }
	}

	public class DPS
	{
		public string value { get; set; }
		public string street_brawl_value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DPSIncrease
	{
		public string value { get; set; }
		public string street_brawl_value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class DPSMax
	{
		public string value { get; set; }
		public string street_brawl_value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class DropDownSpeed
	{
		public string value { get; set; }
	}

	public class EMPDuration
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class EMPProcChance
	{
		public string value { get; set; }
	}

	public class EnableAbilityCharges
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
	}

	public class EndRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class EnemyLifeThreshold
	{
		public string value { get; set; }
		public string postfix { get; set; }
	}

	public class EvasionWhileSliding
	{
		public string value { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ExplodeDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ExplodeRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class ExplosionDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ExplosionRadius
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FervorFireRate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FervorMovespeed
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FervorTechResist
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FireRateBonus
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FireRatePerKill
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FireRateSlow
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class FireRateSlowDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FireRateWhileSliding
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FloatMoveSpeed
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FlyMoveSpeed
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string display_units { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FreezeDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class FullInvisDistance
	{
		public string value { get; set; }
	}

	public class GalvanicBuffDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class GalvanicDebuffDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
	}

	public class GoldPerMinute
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class GravityScale
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class GroundDashReductionPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public bool? negative_attribute { get; set; }
	}

	public class GrowthPerMeter
	{
		public string value { get; set; }
	}

	public class GuardianWardCombatBarrier
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HeadShotBonusDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public ScaleFunction scale_function { get; set; }
	}

	public class HeadshotBonusSteal
	{
		public string value { get; set; }
	}

	public class HealAmount
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealAmpCastPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealAmpReceivePenaltyPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public bool? negative_attribute { get; set; }
	}

	public class HealAmpRegenPenaltyPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public bool? negative_attribute { get; set; }
	}

	public class HealAmpRegenPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
	}

	public class HealFromHero
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealFromNPC
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealingPerCast
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealInterval
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealLifePercentOutOfCombat
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealOnActivate
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealOnKill
	{
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class HealOnLevelHealAmount
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealOnSuccess
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealOnVeil
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealPercentAmount
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealPercentPerHeadshot
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealPerStack
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealthDamagePercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealthDrainedPerSecond
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public bool? negative_attribute { get; set; }
		public string icon { get; set; }
	}

	public class HealthPctDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealthStealPctHero
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HealthThreshold
	{
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HeavyMeleeMultiplier
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class HeightOffGround
	{
		public string value { get; set; }
	}

	public class HeroMultiplier
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class HeroTargetBonus
	{
		public string value { get; set; }
	}

	public class HighGroundBonusWeaponPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class ImbueAbilityLifesteal
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ImbuedBonusDamage
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
	}

	public class ImbuedBonusDuration
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class ImbuedCooldownReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ImbuedTechPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ImmunityDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string tooltip_section { get; set; }
	}

	public class ImpactDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ImpactHeight
	{
		public string value { get; set; }
	}

	public class ImportantPropertiesWithIcon
	{
		public string name { get; set; }
		public string icon { get; set; }
		public string localized_name { get; set; }
	}

	public class InitialFireRateDecrease
	{
		public string value { get; set; }
		public bool negative_attribute { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class InitialWidth
	{
		public string value { get; set; }
	}

	public class InterruptCooldown
	{
		public object value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class Interval
	{
		public string value { get; set; }
	}

	public class IntraBurstFireRateIncrease
	{
		public string value { get; set; }
	}

	public class InvisAlertWhenFading
	{
		public string value { get; set; }
	}

	public class InvisCancelOnDamage
	{
		public string value { get; set; }
	}

	public class InvisDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class InvisFadeToDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class InvisMoveSpeedMod
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string display_units { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class ItemCooldownReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class JumpVelocityHidden
	{
		public string value { get; set; }
	}

	public class KillBonusMoveSpeedPerStack
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class KillWindow
	{
		public string value { get; set; }
	}

	public class LifestealHeal
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class LifestealHealPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class LifestrikeHeal
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class LifestrikeHealPercent
	{
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
	}

	public class LifeThreshold
	{
		public string value { get; set; }
		public string postfix { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class LiftHeight
	{
		public string value { get; set; }
	}

	public class LightMeleeAmmo
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class LightMeleeCooldownMult
	{
		public string value { get; set; }
	}

	public class LightMeleeScale
	{
		public string value { get; set; }
	}

	public class LightMeleeStacks
	{
		public string value { get; set; }
	}

	public class LightMeleeTimeWindow
	{
		public string value { get; set; }
	}

	public class LingerDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class LocalBulletArmorReduction
	{
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public bool negative_attribute { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class LongRangeBonusWeaponPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string conditional { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class LongRangeBonusWeaponPowerMinRange
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class LowHealthLifeStealPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class LowHealthPercentThreshold
	{
		public string value { get; set; }
	}

	public class LowHealthThreshold
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class MagicIncreasePerStack
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MagicResistReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string loc_token_override { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class MaxArmorStacks
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxBonusDuration
	{
		public string value { get; set; }
	}

	public class MaxBulletResist
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxClipBonus
	{
		public string value { get; set; }
	}

	public class MaxFallSpeed
	{
		public string value { get; set; }
	}

	public class MaxFireRateIncrease
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string postfix { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxHealthDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class MaxHealthLossPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public bool negative_attribute { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxHealthPercentAsDPS
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxHeightForBonus
	{
		public string value { get; set; }
	}

	public class MaxHPDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxKillBonusMoveSpeedStack
	{
		public string value { get; set; }
	}

	public class MaxLandingSpeed
	{
		public string value { get; set; }
	}

	public class MaxSlowPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxStacks
	{
		public object value { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxStaminaRestore
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MaxWeaponPower
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class MeleeDistanceScale
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MeleeResistPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MinAimAngle
	{
		public string value { get; set; }
	}

	public class MinHeal
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MinimumDamage
	{
		public string value { get; set; }
	}

	public class MinimumHealAmount
	{
		public string value { get; set; }
	}

	public class MinStaminaRestore
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MinTargetsRequired
	{
		public string value { get; set; }
	}

	public class ModelScale
	{
		public string value { get; set; }
	}

	public class ModelScaleGrowth
	{
		public string value { get; set; }
	}

	public class ModelScaleGrowthTooltip
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MovementSpeedBonusDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class MovementSpeedSlow
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
	}

	public class MovementThresholdSq
	{
		public string value { get; set; }
	}

	public class MoveSpeedMax
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class MoveWhileShootingSpeedPenaltyReductionPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class MoveWhileZoomedSpeedPenaltyReductionPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class NanoTechPerShot
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class NonBurstFireConversionFactor
	{
		public string value { get; set; }
	}

	public class NonHeroAbilityLifestealTooltipOnly
	{
		public string value { get; set; }
		public string postfix { get; set; }
	}

	public class NonHeroHealPct
	{
		public string value { get; set; }
	}

	public class NonHeroMult
	{
		public string value { get; set; }
	}

	public class NonHeroReductionPercent
	{
		public string value { get; set; }
	}

	public class NonHeroStackLimit
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class NonPlayerBonusWeaponPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string conditional { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class NonPlayerBulletResist
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string conditional { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class NormalizedClipEmptySpeedIncrease
	{
		public string value { get; set; }
	}

	public class NPCDamageMult
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class OutgoingDamagePenaltyPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public bool? negative_attribute { get; set; }
	}

	public class OutOfCombatHealthRegen
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class OverdriveClipDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ParryCooldownReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ParrySuccessHealPercentage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class ParticleRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
	}

	public class PercentDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class PerfectBurstWeaponPower
	{
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcAmmoConsumed
	{
		public string value { get; set; }
		public bool negative_attribute { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcBaseAttackDamagePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string display_units { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcBaseAttackDamagePercentAltFire
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string display_units { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcBonusMagicDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcBulletVelocity
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcChance
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ProcCooldown
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class ProcRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class Properties
	{
		public AbilityCooldown AbilityCooldown { get; set; }
		public AbilityDuration AbilityDuration { get; set; }
		public AbilityCastRange AbilityCastRange { get; set; }
		public AbilityUnitTargetLimit AbilityUnitTargetLimit { get; set; }
		public AbilityCastDelay AbilityCastDelay { get; set; }
		public AbilityChannelTime AbilityChannelTime { get; set; }
		public AbilityPostCastDuration AbilityPostCastDuration { get; set; }
		public AbilityCharges AbilityCharges { get; set; }
		public AbilityCooldownBetweenCharge AbilityCooldownBetweenCharge { get; set; }
		public ChannelMoveSpeed ChannelMoveSpeed { get; set; }
		public AbilityResourceCost AbilityResourceCost { get; set; }
		public TechPower TechPower { get; set; }
		public WeaponPower WeaponPower { get; set; }
		public Radius Radius { get; set; }
		public HeightOffGround HeightOffGround { get; set; }
		public BonusClipSizePercent BonusClipSizePercent { get; set; }
		public BaseAttackDamagePercent BaseAttackDamagePercent { get; set; }
		public NonPlayerBonusWeaponPower NonPlayerBonusWeaponPower { get; set; }
		public OutOfCombatHealthRegen OutOfCombatHealthRegen { get; set; }
		public NonPlayerBulletResist NonPlayerBulletResist { get; set; }
		public BonusSoulsPct BonusSoulsPct { get; set; }
		public BonusHealth BonusHealth { get; set; }
		public BonusAbilityCharges BonusAbilityCharges { get; set; }
		public TechRangeMultiplier TechRangeMultiplier { get; set; }
		public TechRadiusMultiplier TechRadiusMultiplier { get; set; }
		public AmmoPerSoul AmmoPerSoul { get; set; }
		public SpiritPowerPerSoul SpiritPowerPerSoul { get; set; }
		public MaxStacks MaxStacks { get; set; }
		public BonusSprintSpeed BonusSprintSpeed { get; set; }
		public BonusClipSize BonusClipSize { get; set; }
		public ProcCooldown ProcCooldown { get; set; }
		public DamagePerChain DamagePerChain { get; set; }
		public BonusPerChain BonusPerChain { get; set; }
		public ChainRadius ChainRadius { get; set; }
		public ProcChance ProcChance { get; set; }
		public ChainCount ChainCount { get; set; }
		public ChainTickRate ChainTickRate { get; set; }
		public Damage Damage { get; set; }
		public MaxSlowPercent MaxSlowPercent { get; set; }
		public SlowDuration SlowDuration { get; set; }
		public BonusFireRate BonusFireRate { get; set; }
		public TechShieldMaxHealth TechShieldMaxHealth { get; set; }
		public GalvanicDebuffDuration GalvanicDebuffDuration { get; set; }
		public ExplodeRadius ExplodeRadius { get; set; }
		public GalvanicBuffDuration GalvanicBuffDuration { get; set; }
		public BuffDamageMult BuffDamageMult { get; set; }
		public BuffMoveSpeedBonus BuffMoveSpeedBonus { get; set; }
		public LifeThreshold LifeThreshold { get; set; }
		public BulletArmorReduction BulletArmorReduction { get; set; }
		public DebuffDuration DebuffDuration { get; set; }
		public EnemyLifeThreshold EnemyLifeThreshold { get; set; }
		public BaseAttackDamagePercentBonus BaseAttackDamagePercentBonus { get; set; }
		public TechResist TechResist { get; set; }
		public MoveWhileShootingSpeedPenaltyReductionPercent MoveWhileShootingSpeedPenaltyReductionPercent { get; set; }
		public MoveWhileZoomedSpeedPenaltyReductionPercent MoveWhileZoomedSpeedPenaltyReductionPercent { get; set; }
		public BonusBulletSpeedPercent BonusBulletSpeedPercent { get; set; }
		public LightMeleeCooldownMult LightMeleeCooldownMult { get; set; }
		public BonusMeleeDamagePercent BonusMeleeDamagePercent { get; set; }
		public LifestrikeHeal LifestrikeHeal { get; set; }
		public LifestrikeHealPercent LifestrikeHealPercent { get; set; }
		public NonHeroHealPct NonHeroHealPct { get; set; }
		public ParryCooldownReduction ParryCooldownReduction { get; set; }
		public BuffDuration BuffDuration { get; set; }
		public BonusDamagePercent BonusDamagePercent { get; set; }
		public ParrySuccessHealPercentage ParrySuccessHealPercentage { get; set; }
		public MeleeResistPercent MeleeResistPercent { get; set; }
		public SpiritPower SpiritPower { get; set; }
		public BonusMoveSpeed BonusMoveSpeed { get; set; }
		public SpellParryDuration SpellParryDuration { get; set; }
		public SpiritPowerInnate SpiritPowerInnate { get; set; }
		public HealOnSuccess HealOnSuccess { get; set; }
		public StatusResistancePercent StatusResistancePercent { get; set; }
		public StaminaCooldownReduction StaminaCooldownReduction { get; set; }
		public SlowPercent SlowPercent { get; set; }
		public GroundDashReductionPercent GroundDashReductionPercent { get; set; }
		public BuildUpDuration BuildUpDuration { get; set; }
		public BuildUpPerShot BuildUpPerShot { get; set; }
		public BulletResist BulletResist { get; set; }
		public DegenResistance DegenResistance { get; set; }
		public CloseRangeBonusWeaponPower CloseRangeBonusWeaponPower { get; set; }
		public CloseRangeBonusDamageRange CloseRangeBonusDamageRange { get; set; }
		public LongRangeBonusWeaponPower LongRangeBonusWeaponPower { get; set; }
		public LongRangeBonusWeaponPowerMinRange LongRangeBonusWeaponPowerMinRange { get; set; }
		public ReloadSpeedMultipler ReloadSpeedMultipler { get; set; }
		public BonusAttackRangePercent BonusAttackRangePercent { get; set; }
		public OutgoingDamagePenaltyPercent OutgoingDamagePenaltyPercent { get; set; }
		public HealAmpReceivePenaltyPercent HealAmpReceivePenaltyPercent { get; set; }
		public HealAmpRegenPenaltyPercent HealAmpRegenPenaltyPercent { get; set; }
		public TechArmorDamageReduction TechArmorDamageReduction { get; set; }
		public AbilityLifestealPercentHero AbilityLifestealPercentHero { get; set; }
		public TickRate TickRate { get; set; }
		public MinTargetsRequired MinTargetsRequired { get; set; }
		public ActiveRadius ActiveRadius { get; set; }
		public ActiveBonusMoveSpeed ActiveBonusMoveSpeed { get; set; }
		public NonHeroMult NonHeroMult { get; set; }
		public ResistReduction ResistReduction { get; set; }
		public BulletShieldDamagePercent BulletShieldDamagePercent { get; set; }
		public TetherDuration TetherDuration { get; set; }
		public ImmunityDuration ImmunityDuration { get; set; }
		public TetherRadius TetherRadius { get; set; }
		public HighGroundBonusWeaponPower HighGroundBonusWeaponPower { get; set; }
		public CooldownOnMiss CooldownOnMiss { get; set; }
		public GrowthPerMeter GrowthPerMeter { get; set; }
		public InitialWidth InitialWidth { get; set; }
		public TechPowerPercent TechPowerPercent { get; set; }
		public SkipFrames SkipFrames { get; set; }
		public TechDamageReduction TechDamageReduction { get; set; }
		public SilenceDuration SilenceDuration { get; set; }
		public EMPDuration EMPDuration { get; set; }
		public DamageDuration DamageDuration { get; set; }
		public DamageToStack DamageToStack { get; set; }
		public WeaponPowerPerStack WeaponPowerPerStack { get; set; }
		public LowHealthThreshold LowHealthThreshold { get; set; }
		public FervorMovespeed FervorMovespeed { get; set; }
		public FervorFireRate FervorFireRate { get; set; }
		public FervorTechResist FervorTechResist { get; set; }
		public LingerDuration LingerDuration { get; set; }
		public StealPerHit StealPerHit { get; set; }
		public StealPerKill StealPerKill { get; set; }
		public StackLostPerDeath StackLostPerDeath { get; set; }
		public StealDuration StealDuration { get; set; }
		public HealthStealPctHero HealthStealPctHero { get; set; }
		public ParticleRadius ParticleRadius { get; set; }
		public HeadShotBonusDamage HeadShotBonusDamage { get; set; }
		public BulletResistReduction BulletResistReduction { get; set; }
		public MagicResistReduction MagicResistReduction { get; set; }
		public DiminishingMultiplier DiminishingMultiplier { get; set; }
		public BonusZoomPercent BonusZoomPercent { get; set; }
		public HealPercentPerHeadshot HealPercentPerHeadshot { get; set; }
		public MovementSpeedBonusDuration MovementSpeedBonusDuration { get; set; }
		public BaseDamagePct BaseDamagePct { get; set; }
		public NanoTechPerShot NanoTechPerShot { get; set; }
		public BaseDamagePerShot BaseDamagePerShot { get; set; }
		public SpellAmplificationMultiplier SpellAmplificationMultiplier { get; set; }
		public ProcBonusMagicDamage ProcBonusMagicDamage { get; set; }
		public CritDamagePercent CritDamagePercent { get; set; }
		public DotHealthPercent DotHealthPercent { get; set; }
		public DotDuration DotDuration { get; set; }
		public DotMultiplerTroopers DotMultiplerTroopers { get; set; }
		public RicochetDamagePercent RicochetDamagePercent { get; set; }
		public RicochetRadius RicochetRadius { get; set; }
		public RicochetTargetsTooltipOnly RicochetTargetsTooltipOnly { get; set; }
		public BonusHealthRegen BonusHealthRegen { get; set; }
		public BulletLifestealPercent BulletLifestealPercent { get; set; }
		public AirJumps AirJumps { get; set; }
		public AirJumpVerticalSpeedPercent AirJumpVerticalSpeedPercent { get; set; }
		public InterruptCooldown InterruptCooldown { get; set; }
		public HealInterval HealInterval { get; set; }
		public HealAmount HealAmount { get; set; }
		public HealRadius HealRadius { get; set; }
		public TechArmor TechArmor { get; set; }
		public HealPercentAmount HealPercentAmount { get; set; }
		public RegenDuration RegenDuration { get; set; }
		public HealOnActivate HealOnActivate { get; set; }
		public DamageThreshold DamageThreshold { get; set; }
		public DamageReduction DamageReduction { get; set; }
		public BulletArmor BulletArmor { get; set; }
		public WeaponPowerWhileActivated WeaponPowerWhileActivated { get; set; }
		public HealthDrainedPerSecond HealthDrainedPerSecond { get; set; }
		public Interval Interval { get; set; }
		public CombatBarrier CombatBarrier { get; set; }
		public BulletShieldMaxHealth BulletShieldMaxHealth { get; set; }
		public MaxBulletResist MaxBulletResist { get; set; }
		public StackLossFrequency StackLossFrequency { get; set; }
		public ArmorLossPerHit ArmorLossPerHit { get; set; }
		public HealthThreshold HealthThreshold { get; set; }
		public TechResistBelowThreshold TechResistBelowThreshold { get; set; }
		public BulletResistBelowThreshold BulletResistBelowThreshold { get; set; }
		public ActiveMoveSpeedPenalty ActiveMoveSpeedPenalty { get; set; }
		public HealAmpCastPercent HealAmpCastPercent { get; set; }
		public HealAmpRegenPercent HealAmpRegenPercent { get; set; }
		public RestoreDelay RestoreDelay { get; set; }
		public HealLifePercentOutOfCombat HealLifePercentOutOfCombat { get; set; }
		public HealOnKill HealOnKill { get; set; }
		public FireRateSlow FireRateSlow { get; set; }
		public StackingBonusHealth StackingBonusHealth { get; set; }
		public StackingBonusSprintSpeed StackingBonusSprintSpeed { get; set; }
		public StackingTechRangeMultiplier StackingTechRangeMultiplier { get; set; }
		public StackingTechRadiusMultiplier StackingTechRadiusMultiplier { get; set; }
		public StackingGoldPerMinute StackingGoldPerMinute { get; set; }
		public ThinkRate ThinkRate { get; set; }
		public SlowResistancePercent SlowResistancePercent { get; set; }
		public Stamina Stamina { get; set; }
		public AirMoveIncreasePercent AirMoveIncreasePercent { get; set; }
		public SingleTargetPlayerMultiplier SingleTargetPlayerMultiplier { get; set; }
		public InvisAlertWhenFading InvisAlertWhenFading { get; set; }
		public InvisCancelOnDamage InvisCancelOnDamage { get; set; }
		public InvisFadeToDuration InvisFadeToDuration { get; set; }
		public InvisMoveSpeedMod InvisMoveSpeedMod { get; set; }
		public SpottedRadius SpottedRadius { get; set; }
		public RevealOnDamageDuration RevealOnDamageDuration { get; set; }
		public RevealOnSpottedDuration RevealOnSpottedDuration { get; set; }
		public MovementThresholdSq MovementThresholdSq { get; set; }
		public RegenWhileInvisible RegenWhileInvisible { get; set; }
		public DamageWindow DamageWindow { get; set; }
		public BarrierDuration BarrierDuration { get; set; }
		public CooldownReduction CooldownReduction { get; set; }
		public Regeneration Regeneration { get; set; }
		public RegenerationDuration RegenerationDuration { get; set; }
		public BonusSpirit BonusSpirit { get; set; }
		public BonusAbilityDurationPercent BonusAbilityDurationPercent { get; set; }
		public BulletDamageReflectedPct BulletDamageReflectedPct { get; set; }
		public SpiritDamageReflectedPct SpiritDamageReflectedPct { get; set; }
		public ReturnFireBulletResist ReturnFireBulletResist { get; set; }
		public BonusSpiritForChargedAbilities BonusSpiritForChargedAbilities { get; set; }
		public NonHeroAbilityLifestealTooltipOnly NonHeroAbilityLifestealTooltipOnly { get; set; }
		public SpiritSteal SpiritSteal { get; set; }
		public SpiritStealDuration SpiritStealDuration { get; set; }
		public TechDamagePercent TechDamagePercent { get; set; }
		public DelayDuration DelayDuration { get; set; }
		public MinimumDamage MinimumDamage { get; set; }
		public ImbueAbilityLifesteal ImbueAbilityLifesteal { get; set; }
		public MovementSpeedSlow MovementSpeedSlow { get; set; }
		public MaxHealthDamage MaxHealthDamage { get; set; }
		public AbilityChargeUpTime AbilityChargeUpTime { get; set; }
		public CurrentHealthDamage CurrentHealthDamage { get; set; }
		public ReProcLockoutTime ReProcLockoutTime { get; set; }
		public WatcherMaxDuration WatcherMaxDuration { get; set; }
		public MagicIncreasePerStack MagicIncreasePerStack { get; set; }
		public CooldownBetweenChargeReduction CooldownBetweenChargeReduction { get; set; }
		public CooldownReductionOnChargedAbilities CooldownReductionOnChargedAbilities { get; set; }
		public BonusAbilityChargesNonCharge BonusAbilityChargesNonCharge { get; set; }
		public EnableAbilityCharges EnableAbilityCharges { get; set; }
		public ItemCooldownReduction ItemCooldownReduction { get; set; }
		public CasterBuffDuration CasterBuffDuration { get; set; }
		public DamagePulseInterval DamagePulseInterval { get; set; }
		public DamagePulseAmount DamagePulseAmount { get; set; }
		public DamagePulseRadius DamagePulseRadius { get; set; }
		public TechPowerReduction TechPowerReduction { get; set; }
		public PercentDamage PercentDamage { get; set; }
		public ResistReductionDuration ResistReductionDuration { get; set; }
		public SelfModifier SelfModifier { get; set; }
		public RespawnDelay RespawnDelay { get; set; }
		public RespawnBonusHealthDuration RespawnBonusHealthDuration { get; set; }
		public SpawnTimePenalty SpawnTimePenalty { get; set; }
		public RespawnHealthPercent RespawnHealthPercent { get; set; }
		public BonusDamagePerHero BonusDamagePerHero { get; set; }
		public TechCleaveDamagePercent TechCleaveDamagePercent { get; set; }
		public TechCleaveRadius TechCleaveRadius { get; set; }
		public BonusChargedAbilityDamage BonusChargedAbilityDamage { get; set; }
		public BonusChargedCooldownReduction BonusChargedCooldownReduction { get; set; }
		public MaxHealthPercentAsDPS MaxHealthPercentAsDPS { get; set; }
		public AuraRadius AuraRadius { get; set; }
		public TempTechShieldHealth TempTechShieldHealth { get; set; }
		public StunDelay StunDelay { get; set; }
		public StunDuration StunDuration { get; set; }
		public VisualContractRadius VisualContractRadius { get; set; }
		public MaxBonusDuration MaxBonusDuration { get; set; }
		public MaxHeightForBonus MaxHeightForBonus { get; set; }
		public ImpactDamage ImpactDamage { get; set; }
		public CaptureRadius CaptureRadius { get; set; }
		public DeathImmunityDuration DeathImmunityDuration { get; set; }
		public DeathImmunityDamageReduction DeathImmunityDamageReduction { get; set; }
		public FullInvisDistance FullInvisDistance { get; set; }
		public AmbushDuration AmbushDuration { get; set; }
		public AmbushBonusFireRate AmbushBonusFireRate { get; set; }
		public AmbushBonusTechPower AmbushBonusTechPower { get; set; }
		public AmbushBonusMeleeDamage AmbushBonusMeleeDamage { get; set; }
		public BonusFireRateNPC BonusFireRateNPC { get; set; }
		public HealthDamagePercent HealthDamagePercent { get; set; }
		public BonusReloadSpeed BonusReloadSpeed { get; set; }
		public BonusWeaponPower BonusWeaponPower { get; set; }
		public OverdriveClipDuration OverdriveClipDuration { get; set; }
		public JumpVelocityHidden JumpVelocityHidden { get; set; }
		public AirControlPercent AirControlPercent { get; set; }
		public SlamDownRadius SlamDownRadius { get; set; }
		public VerticalDifferenceTolerance VerticalDifferenceTolerance { get; set; }
		public TossSpeed TossSpeed { get; set; }
		public DropDownSpeed DropDownSpeed { get; set; }
		public MaxLandingSpeed MaxLandingSpeed { get; set; }
		public ImpactHeight ImpactHeight { get; set; }
		public MinAimAngle MinAimAngle { get; set; }
		public ActivateTime ActivateTime { get; set; }
		public AssaultLifestealPercent AssaultLifestealPercent { get; set; }
		public AssaultDuration AssaultDuration { get; set; }
		public AssaultFireRate AssaultFireRate { get; set; }
		public TotalHealthRegen TotalHealthRegen { get; set; }
		public HeroTargetBonus HeroTargetBonus { get; set; }
		public HealPerStack HealPerStack { get; set; }
		public MinStaminaRestore MinStaminaRestore { get; set; }
		public MaxStaminaRestore MaxStaminaRestore { get; set; }
		public ShrinkDuration ShrinkDuration { get; set; }
		public ModelScaleGrowth ModelScaleGrowth { get; set; }
		public ModelScaleGrowthTooltip ModelScaleGrowthTooltip { get; set; }
		public AbilityLifestealPercentHeroPassive AbilityLifestealPercentHeroPassive { get; set; }
		public CooldownReductionPctOnOthers CooldownReductionPctOnOthers { get; set; }
		public GuardianWardCombatBarrier GuardianWardCombatBarrier { get; set; }
		public DPS DPS { get; set; }
		public DPSIncrease DPSIncrease { get; set; }
		public DPSMax DPSMax { get; set; }
		public NonHeroReductionPercent NonHeroReductionPercent { get; set; }
		public SlideScale SlideScale { get; set; }
		public TechRadiusMultiplierBuff TechRadiusMultiplierBuff { get; set; }
		public TechRangeMultiplierBuff TechRangeMultiplierBuff { get; set; }
		public WeaponPowerPerKill WeaponPowerPerKill { get; set; }
		public WeaponPowerPerDeath WeaponPowerPerDeath { get; set; }
		public KillWindow KillWindow { get; set; }
		public MaxWeaponPower MaxWeaponPower { get; set; }
		public BaseBonusCounter BaseBonusCounter { get; set; }
		public BonusBaseHealth BonusBaseHealth { get; set; }
		public BuffBulletResist BuffBulletResist { get; set; }
		public BuffTechResist BuffTechResist { get; set; }
		public SpreadDuration SpreadDuration { get; set; }
		public StartRadius StartRadius { get; set; }
		public EndRadius EndRadius { get; set; }
		public DamageHeight DamageHeight { get; set; }
		public NPCDamageMult NPCDamageMult { get; set; }
		public FreezeDuration FreezeDuration { get; set; }
		public DampingFactor DampingFactor { get; set; }
		public LiftHeight LiftHeight { get; set; }
		public FloatMoveSpeed FloatMoveSpeed { get; set; }
		public StasisRadius StasisRadius { get; set; }
		public ExplodeDamage ExplodeDamage { get; set; }
		public EMPProcChance EMPProcChance { get; set; }
		public MaxFallSpeed MaxFallSpeed { get; set; }
		public SlamdownSpeed SlamdownSpeed { get; set; }
		public MoveSpeedMax MoveSpeedMax { get; set; }
		public ImbuedBonusDuration ImbuedBonusDuration { get; set; }
		public ImbuedBonusDamage ImbuedBonusDamage { get; set; }
		public MaxHealthLossPercent MaxHealthLossPercent { get; set; }
		public BonusClipPerKill BonusClipPerKill { get; set; }
		public FireRatePerKill FireRatePerKill { get; set; }
		public ActiveBonusFireRate ActiveBonusFireRate { get; set; }
		public ActiveBonusLifesteal ActiveBonusLifesteal { get; set; }
		public ActiveReloadPercent ActiveReloadPercent { get; set; }
		public LowHealthPercentThreshold LowHealthPercentThreshold { get; set; }
		public LowHealthLifeStealPercent LowHealthLifeStealPercent { get; set; }
		public KillBonusMoveSpeedPerStack KillBonusMoveSpeedPerStack { get; set; }
		public MaxKillBonusMoveSpeedStack MaxKillBonusMoveSpeedStack { get; set; }
		public CycleTimeFireRateDecrease CycleTimeFireRateDecrease { get; set; }
		public BurstFireShotPercent BurstFireShotPercent { get; set; }
		public NormalizedClipEmptySpeedIncrease NormalizedClipEmptySpeedIncrease { get; set; }
		public BurstFireShotsFromClipPercent BurstFireShotsFromClipPercent { get; set; }
		public PerfectBurstWeaponPower PerfectBurstWeaponPower { get; set; }
		public BonusHeadshotDamage BonusHeadshotDamage { get; set; }
		public BaseBonusWeaponPower BaseBonusWeaponPower { get; set; }
		public IntraBurstFireRateIncrease IntraBurstFireRateIncrease { get; set; }
		public NonBurstFireConversionFactor NonBurstFireConversionFactor { get; set; }
		public LifestealHeal LifestealHeal { get; set; }
		public LifestealHealPercent LifestealHealPercent { get; set; }
		public SpiritDamage SpiritDamage { get; set; }
		public LightMeleeScale LightMeleeScale { get; set; }
		public TechArmorGain TechArmorGain { get; set; }
		public TechPowerGain TechPowerGain { get; set; }
		public MeleeDistanceScale MeleeDistanceScale { get; set; }
		public BonusHeavyMeleeDamage BonusHeavyMeleeDamage { get; set; }
		public LightMeleeStacks LightMeleeStacks { get; set; }
		public LightMeleeAmmo LightMeleeAmmo { get; set; }
		public HeavyMeleeMultiplier HeavyMeleeMultiplier { get; set; }
		public CooldownReductionFlat CooldownReductionFlat { get; set; }
		public LightMeleeTimeWindow LightMeleeTimeWindow { get; set; }
		public SpinUpTime SpinUpTime { get; set; }
		public SpinUpDecay SpinUpDecay { get; set; }
		public InitialFireRateDecrease InitialFireRateDecrease { get; set; }
		public MaxFireRateIncrease MaxFireRateIncrease { get; set; }
		public BonusReloadTime BonusReloadTime { get; set; }
		public ModelScale ModelScale { get; set; }
		public TrackingSpeed TrackingSpeed { get; set; }
		public TurretAttackDelay TurretAttackDelay { get; set; }
		public TurretAttackRange TurretAttackRange { get; set; }
		public TurretDeployTime TurretDeployTime { get; set; }
		public TurretLifetime TurretLifetime { get; set; }
		public AttackConeAngle AttackConeAngle { get; set; }
		public StationaryWeaponPower StationaryWeaponPower { get; set; }
		public StationaryRecoilReduction StationaryRecoilReduction { get; set; }
		public CasterHealthPercent CasterHealthPercent { get; set; }
		public BulletSpeedOverride BulletSpeedOverride { get; set; }
		public HealingPerCast HealingPerCast { get; set; }
		public ActivatedFireRate ActivatedFireRate { get; set; }
		public BonusMoveSpeed BonusMovespeed { get; set; }
		public BonusSpiritMaxTime BonusSpiritMaxTime { get; set; }
		public BonusSpiritWindow BonusSpiritWindow { get; set; }
		public BonusSpiritMin BonusSpiritMin { get; set; }
		public ImbuedTechPower ImbuedTechPower { get; set; }
		public FireRateBonus FireRateBonus { get; set; }
		public AmmoReloadPercent AmmoReloadPercent { get; set; }
		public BulletsBonusMagicDamage BulletsBonusMagicDamage { get; set; }
		public SpiritStolePerHit SpiritStolePerHit { get; set; }
		public HeadshotBonusSteal HeadshotBonusSteal { get; set; }
		public ShootDurationForMax ShootDurationForMax { get; set; }
		public BaseAttackDamagePercentAtMaxDuration BaseAttackDamagePercentAtMaxDuration { get; set; }
		public MaxArmorStacks MaxArmorStacks { get; set; }
		public BulletResistPerStack BulletResistPerStack { get; set; }
		public BulletResistDuration BulletResistDuration { get; set; }
		public LocalBulletArmorReduction LocalBulletArmorReduction { get; set; }
		public InvisDuration InvisDuration { get; set; }
		public HealOnVeil HealOnVeil { get; set; }
		public VexBarrierCombatBarrier VexBarrierCombatBarrier { get; set; }
		public HealFromHero HealFromHero { get; set; }
		public HealFromNPC HealFromNPC { get; set; }
		public BonusShotsDuration BonusShotsDuration { get; set; }
		public BulletSplitShot BulletSplitShot { get; set; }
		public SpreadAngleDegrees SpreadAngleDegrees { get; set; }
		public SpecialShotsBonusFireRate SpecialShotsBonusFireRate { get; set; }
		public WeaponDamageBonusDuration WeaponDamageBonusDuration { get; set; }
		public WeaponDamagePerStack WeaponDamagePerStack { get; set; }
		public SummonDuration SummonDuration { get; set; }
		public FlyMoveSpeed FlyMoveSpeed { get; set; }
		public SpellShieldLingerDuration SpellShieldLingerDuration { get; set; }
		public SpellShieldFlavorText SpellShieldFlavorText { get; set; }
		public StoredSpiritDamage StoredSpiritDamage { get; set; }
		public MaxClipBonus MaxClipBonus { get; set; }
		public HealOnLevelHealAmount HealOnLevelHealAmount { get; set; }
		public DamageThresholdDuration DamageThresholdDuration { get; set; }
		public ExplosionDamage ExplosionDamage { get; set; }
		public ExplosionRadius ExplosionRadius { get; set; }
		public CooldownReductionPctOnNonHeroes CooldownReductionPctOnNonHeroes { get; set; }
		public DamagePctVsNonHeroes DamagePctVsNonHeroes { get; set; }
		public DelayBeforeStun DelayBeforeStun { get; set; }
		public HeroMultiplier HeroMultiplier { get; set; }
		public ArmingTime ArmingTime { get; set; }
		public CooldownReductionPerHit CooldownReductionPerHit { get; set; }
		public MinimumHealAmount MinimumHealAmount { get; set; }
		public DeflectionPercent DeflectionPercent { get; set; }
		public BulletProcDeflectionPercent BulletProcDeflectionPercent { get; set; }
		public DeflectionRandomness DeflectionRandomness { get; set; }
		public SpiritDamageReductionProc SpiritDamageReductionProc { get; set; }
		public FireRateSlowDuration FireRateSlowDuration { get; set; }
		public ProcRadius ProcRadius { get; set; }
		public DebuffRadius DebuffRadius { get; set; }
		public ReduceFootstepSound ReduceFootstepSound { get; set; }
		public ProcAmmoConsumed ProcAmmoConsumed { get; set; }
		public ProcBulletVelocity ProcBulletVelocity { get; set; }
		public ProcBaseAttackDamagePercent ProcBaseAttackDamagePercent { get; set; }
		public ProcBaseAttackDamagePercentAltFire ProcBaseAttackDamagePercentAltFire { get; set; }
		public AirBonusDamageGiven AirBonusDamageGiven { get; set; }
		public AirBonusDamageTaken AirBonusDamageTaken { get; set; }
		public GravityScale GravityScale { get; set; }
		public AirControlAccelPercent AirControlAccelPercent { get; set; }
		public DazeMoveSpeed DazeMoveSpeed { get; set; }
		public DazeDuration DazeDuration { get; set; }
		public MinHeal MinHeal { get; set; }
		public RespawnTime RespawnTime { get; set; }
		public BuffFrequency BuffFrequency { get; set; }
		public AllyPercentage AllyPercentage { get; set; }
		public BulletRadius BulletRadius { get; set; }
		public HealthPctDamage HealthPctDamage { get; set; }
		public StatusImmuneDuration StatusImmuneDuration { get; set; }
		public CooldownReductionOnHitMin CooldownReductionOnHitMin { get; set; }
		public CooldownReductionOnHitPct CooldownReductionOnHitPct { get; set; }
		public SlideTurnScale SlideTurnScale { get; set; }
		public EvasionWhileSliding EvasionWhileSliding { get; set; }
		public FireRateWhileSliding FireRateWhileSliding { get; set; }
		public BeamLength BeamLength { get; set; }
		public BeamWidth BeamWidth { get; set; }
		public MaxHPDamage MaxHPDamage { get; set; }
		public ImbuedCooldownReduction ImbuedCooldownReduction { get; set; }
		public ResistStealAmount ResistStealAmount { get; set; }
		public WeaponPowerPerStackNonHero WeaponPowerPerStackNonHero { get; set; }
		public NonHeroStackLimit NonHeroStackLimit { get; set; }
		public GoldPerMinute GoldPerMinute { get; set; }
		public BonusGoldPerMinute BonusGoldPerMinute { get; set; }
		public StartingGold StartingGold { get; set; }
		public BonusBuffsPerGold BonusBuffsPerGold { get; set; }
	}

	public class PropertyUpgrade
	{
		public string name { get; set; }
		public string bonus { get; set; }
	}

	public class Radius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ReduceFootstepSound
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RegenDuration
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class Regeneration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RegenerationDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RegenWhileInvisible
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class ReloadSpeedMultipler
	{
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class ReProcLockoutTime
	{
		public string value { get; set; }
	}

	public class ResistReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string icon { get; set; }
	}

	public class ResistReductionDuration
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ResistStealAmount
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RespawnBonusHealthDuration
	{
		public string value { get; set; }
		public string postfix { get; set; }
	}

	public class RespawnDelay
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RespawnHealthPercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RespawnTime
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RestoreDelay
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ReturnFireBulletResist
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class RevealOnDamageDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class RevealOnSpottedDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class RicochetDamagePercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RicochetRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class RicochetTargetsTooltipOnly
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	

	public class ScaleFunction
	{
		public string class_name { get; set; }
		public string subclass_name { get; set; }
		public string specific_stat_scale_type { get; set; }
		public double stat_scale { get; set; }
		public List<string> scaling_stats { get; set; }
		public double street_brawl_stat_scale { get; set; }
	}

	public class SectionAttribute
	{
		public List<string> properties { get; set; }
		public List<string> elevated_properties { get; set; }
		public string loc_string { get; set; }
		public List<string> important_properties { get; set; }
		public List<ImportantPropertiesWithIcon> important_properties_with_icon { get; set; }
	}

	public class SelfModifier
	{
		public string value { get; set; }
		public string postfix { get; set; }
	}

	public class ShootDurationForMax
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ShrinkDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SilenceDuration
	{
		public string value { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SingleTargetPlayerMultiplier
	{
		public string value { get; set; }
	}

	public class SkipFrames
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class SlamDownRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class SlamdownSpeed
	{
		public string value { get; set; }
	}

	public class SlideScale
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SlideTurnScale
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
	}

	public class SlowDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class SlowPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class SlowResistancePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpawnTimePenalty
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public bool negative_attribute { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpecialShotsBonusFireRate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class SpellAmplificationMultiplier
	{
		public string value { get; set; }
		public string display_units { get; set; }
	}

	public class SpellParryDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpellShieldFlavorText
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpellShieldLingerDuration
	{
		public string value { get; set; }
	}

	public class SpinUpDecay
	{
		public string value { get; set; }
	}

	public class SpinUpTime
	{
		public string value { get; set; }
		public bool negative_attribute { get; set; }
		public string postfix { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritDamageReductionProc
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritDamageReflectedPct
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritPower
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritPowerInnate
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritPowerPerSoul
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritSteal
	{
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpiritStealDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class SpiritStolePerHit
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SpottedRadius
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class SpreadAngleDegrees
	{
		public string value { get; set; }
	}

	public class SpreadDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class StackingBonusHealth
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StackingBonusSprintSpeed
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StackingGoldPerMinute
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StackingTechRadiusMultiplier
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class StackingTechRangeMultiplier
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StackLossFrequency
	{
		public string value { get; set; }
		public string postfix { get; set; }
	}

	public class StackLostPerDeath
	{
		public string value { get; set; }
	}

	public class Stamina
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StaminaCooldownReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public bool negative_attribute { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class StartingGold
	{
		public string value { get; set; }
	}

	public class StartRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string icon { get; set; }
	}

	public class StasisRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StationaryRecoilReduction
	{
		public string value { get; set; }
		public string postfix { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StationaryWeaponPower
	{
		public string value { get; set; }
		public string prefix { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StatusImmuneDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StatusResistancePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StealDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StealPerHit
	{
		public string value { get; set; }
	}

	public class StealPerKill
	{
		public string value { get; set; }
	}

	public class StoredSpiritDamage
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class StunDelay
	{
		public object value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class StunDuration
	{
		public object value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class SummonDuration
	{
		public string value { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechArmor
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechArmorDamageReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string loc_token_override { get; set; }
	}

	public class TechArmorGain
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechCleaveDamagePercent
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class TechCleaveRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechDamagePercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechDamageReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechPower
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string provided_property_type { get; set; }
		public string disable_value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class TechPowerGain
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechPowerPercent
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechPowerReduction
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class TechRadiusMultiplier
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class TechRadiusMultiplierBuff
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class TechRangeMultiplier
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechRangeMultiplierBuff
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechResist
	{
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string value { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
		public List<string> usage_flags { get; set; }
	}

	public class TechResistBelowThreshold
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TechShieldMaxHealth
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
	}

	public class TempTechShieldHealth
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class TetherDuration
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TetherRadius
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string display_units { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class ThinkRate
	{
		public string value { get; set; }
	}

	public class TickRate
	{
		public string value { get; set; }
	}

	public class TooltipSection
	{
		public string section_type { get; set; }
		public List<SectionAttribute> section_attributes { get; set; }
	}

	public class TossSpeed
	{
		public string value { get; set; }
	}

	public class TotalHealthRegen
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TrackingSpeed
	{
		public string value { get; set; }
	}

	public class TurretAttackDelay
	{
		public string value { get; set; }
	}

	public class TurretAttackRange
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class TurretDeployTime
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string postfix { get; set; }
		public string icon { get; set; }
	}

	public class TurretLifetime
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class Upgrade
	{
		public List<PropertyUpgrade> property_upgrades { get; set; }
	}

	public class VerticalDifferenceTolerance
	{
		public string value { get; set; }
	}

	public class VexBarrierCombatBarrier
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string css_class { get; set; }
		public List<string> usage_flags { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string label { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class VisualContractRadius
	{
		public string value { get; set; }
	}

	public class WatcherMaxDuration
	{
		public string value { get; set; }
	}

	public class WeaponDamageBonusDuration
	{
		public string value { get; set; }
		public string loc_token_override { get; set; }
		public ScaleFunction scale_function { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class WeaponDamagePerStack
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class WeaponInfo
	{
	}

	public class WeaponPower
	{
		public string value { get; set; }
		public bool can_set_token_override { get; set; }
		public string provided_property_type { get; set; }
		public string disable_value { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
	}

	public class WeaponPowerPerDeath
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string icon { get; set; }
	}

	public class WeaponPowerPerKill
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string tooltip_section { get; set; }
		public bool? tooltip_is_elevated { get; set; }
		public bool? tooltip_is_important { get; set; }
	}

	public class WeaponPowerPerStack
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string icon { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
		public string provided_property_type { get; set; }
		public List<string> usage_flags { get; set; }
		public string display_units { get; set; }
		public string tooltip_section { get; set; }
	}

	public class WeaponPowerPerStackNonHero
	{
		public string value { get; set; }
		public string provided_property_type { get; set; }
		public string prefix { get; set; }
		public string label { get; set; }
		public string postfix { get; set; }
		public string postvalue_label { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}

	public class WeaponPowerWhileActivated
	{
		public string value { get; set; }
		public string css_class { get; set; }
		public string prefix { get; set; }
		public string icon { get; set; }
		public string tooltip_section { get; set; }
		public bool tooltip_is_elevated { get; set; }
		public bool tooltip_is_important { get; set; }
	}


}
