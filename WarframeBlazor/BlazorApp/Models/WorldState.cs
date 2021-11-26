using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
  // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
  public class CountedItem
  {
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
  }

  public class Reward
  {
    [JsonPropertyName("countedItems")]
    public List<CountedItem> CountedItems { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("credits")]
    public int Credits { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("items")]
    public List<string> Items { get; set; }

    [JsonPropertyName("itemString")]
    public string ItemString { get; set; }
  }

  public class Mission
  {
    [JsonPropertyName("reward")]
    public Reward Reward { get; set; }

    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("maxEnemyLevel")]
    public int MaxEnemyLevel { get; set; }

    [JsonPropertyName("minEnemyLevel")]
    public int MinEnemyLevel { get; set; }

    [JsonPropertyName("maxWaveNum")]
    public int MaxWaveNum { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("nightmare")]
    public bool Nightmare { get; set; }

    [JsonPropertyName("archwingRequired")]
    public bool ArchwingRequired { get; set; }

    [JsonPropertyName("isSharkwing")]
    public bool IsSharkwing { get; set; }

    [JsonPropertyName("enemySpec")]
    public string EnemySpec { get; set; }

    [JsonPropertyName("levelOverride")]
    public string LevelOverride { get; set; }

    [JsonPropertyName("advancedSpawners")]
    public List<string> AdvancedSpawners { get; set; }

    [JsonPropertyName("requiredItems")]
    public List<string> RequiredItems { get; set; }

    [JsonPropertyName("consumeRequiredItems")]
    public bool ConsumeRequiredItems { get; set; }

    [JsonPropertyName("leadersAlwaysAllowed")]
    public bool LeadersAlwaysAllowed { get; set; }

    [JsonPropertyName("levelAuras")]
    public List<string> LevelAuras { get; set; }
  }

  public class Alerts
  {
    [JsonPropertyName("mission")]
    public Mission Mission { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("rewardTypes")]
    public List<string> RewardTypes { get; set; }
  }

  public class Arbitration
  {
    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("enemy")]
    public string Enemy { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("archwing")]
    public bool Archwing { get; set; }

    [JsonPropertyName("sharkwing")]
    public bool Sharkwing { get; set; }
  }

  public class CetusCycle
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("activation")]
    public string Activation { get; set; }

    [JsonPropertyName("isDay")]
    public bool IsDay { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("timeLeft")]
    public string TimeLeft { get; set; }

    [JsonPropertyName("isCetus")]
    public bool IsCetus { get; set; }

    [JsonPropertyName("shortString")]
    public string ShortString { get; set; }
  }

  public class ConstructionProgress
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("fomorianProgress")]
    public string FomorianProgress { get; set; }

    [JsonPropertyName("razorbackProgress")]
    public string RazorbackProgress { get; set; }

    [JsonPropertyName("unknownProgress")]
    public string UnknownProgress { get; set; }
  }

  public class ConclaveChallenge
  {
    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("endString")]
    public string EndString { get; set; }

    [JsonPropertyName("daily")]
    public bool Daily { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("rootChallenge")]
    public bool RootChallenge { get; set; }
  }

  public class DailyDeal
  {
    [JsonPropertyName("sold")]
    public int Sold { get; set; }

    [JsonPropertyName("item")]
    public string Item { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("originalPrice")]
    public int OriginalPrice { get; set; }

    [JsonPropertyName("salePrice")]
    public int SalePrice { get; set; }

    [JsonPropertyName("discount")]
    public int Discount { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
  }

  public class History
  {
    [JsonPropertyName("defender")]
    public string Defender { get; set; }

    [JsonPropertyName("defenderIsAlliance")]
    public bool DefenderIsAlliance { get; set; }

    [JsonPropertyName("attacker")]
    public string Attacker { get; set; }

    [JsonPropertyName("winner")]
    public string Winner { get; set; }

    [JsonPropertyName("start")]
    public string Start { get; set; }

    [JsonPropertyName("end")]
    public string End { get; set; }
  }

  public class DarkSector
  {
    [JsonPropertyName("defenderMOTD")]
    public string DefenderMOTD { get; set; }

    [JsonPropertyName("deployerName")]
    public string DeployerName { get; set; }

    [JsonPropertyName("defenderDeploymentActivation")]
    public int DefenderDeploymentActivation { get; set; }

    [JsonPropertyName("defenderName")]
    public string DefenderName { get; set; }

    [JsonPropertyName("deployerClan")]
    public string DeployerClan { get; set; }

    [JsonPropertyName("isAlliance")]
    public bool IsAlliance { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("history")]
    public List<History> History { get; set; }
  }

  public class EarthCycle
  {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("isDay")]
    public bool IsDay { get; set; }

    [JsonPropertyName("timeLeft")]
    public string TimeLeft { get; set; }
  }

  public class Reward2
  {
    [JsonPropertyName("countedItems")]
    public List<CountedItem> CountedItems { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("credits")]
    public int Credits { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("items")]
    public List<string> Items { get; set; }

    [JsonPropertyName("itemString")]
    public string ItemString { get; set; }
  }

  public class Job
  {
    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("rewardPool")]
    public List<string> RewardPool { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("enemyLevels")]
    public List<int> EnemyLevels { get; set; }

    [JsonPropertyName("standingStages")]
    public List<int> StandingStages { get; set; }

    [JsonPropertyName("minMR")]
    public int MinMR { get; set; }
  }

  public class Message
  {
    [JsonPropertyName("sender")]
    public string Sender { get; set; }

    [JsonPropertyName("subject")]
    public string Subject { get; set; }

    [JsonPropertyName("message")]
    public string Messages { get; set; }

    [JsonPropertyName("senderIcon")]
    public string SenderIcon { get; set; }

    [JsonPropertyName("attachments")]
    public List<string> Attachments { get; set; }
  }

  public class InterimStep
  {
    [JsonPropertyName("goal")]
    public int Goal { get; set; }

    [JsonPropertyName("reward")]
    public Reward Reward { get; set; }

    [JsonPropertyName("message")]
    public Message Message { get; set; }

    [JsonPropertyName("winnerCount")]
    public int WinnerCount { get; set; }
  }

  public class ProgressSteps
  {
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("progressAmt")]
    public int ProgressAmt { get; set; }
  }

  public class Metadata
  {
  }

  public class NextAlt
  {
    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }
  }

  public class Event
  {
    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("maximumScore")]
    public int MaximumScore { get; set; }

    [JsonPropertyName("currentScore")]
    public int CurrentScore { get; set; }

    [JsonPropertyName("smallInterval")]
    public int SmallInterval { get; set; }

    [JsonPropertyName("largeInterval")]
    public int LargeInterval { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("tooltip")]
    public string Tooltip { get; set; }

    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("concurrentNodes")]
    public List<string> ConcurrentNodes { get; set; }

    [JsonPropertyName("victimNode")]
    public string VictimNode { get; set; }

    [JsonPropertyName("scoreLocTag")]
    public string ScoreLocTag { get; set; }

    [JsonPropertyName("rewards")]
    public List<Reward> Rewards { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("health")]
    public int Health { get; set; }

    [JsonPropertyName("affiliatedWith")]
    public string AffiliatedWith { get; set; }

    [JsonPropertyName("jobs")]
    public List<Job> Jobs { get; set; }

    [JsonPropertyName("interimSteps")]
    public List<InterimStep> InterimSteps { get; set; }

    [JsonPropertyName("progressSteps")]
    public ProgressSteps ProgressSteps { get; set; }

    [JsonPropertyName("progressTotal")]
    public int ProgressTotal { get; set; }

    [JsonPropertyName("showTotalAtEndOfMission")]
    public bool ShowTotalAtEndOfMission { get; set; }

    [JsonPropertyName("isPersonal")]
    public bool IsPersonal { get; set; }

    [JsonPropertyName("isCommunity")]
    public bool IsCommunity { get; set; }

    [JsonPropertyName("regionDrops")]
    public List<string> RegionDrops { get; set; }

    [JsonPropertyName("archwingDrops")]
    public List<string> ArchwingDrops { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; }

    [JsonPropertyName("completionBonuses")]
    public List<int> CompletionBonuses { get; set; }

    [JsonPropertyName("scoreVar")]
    public string ScoreVar { get; set; }

    [JsonPropertyName("altExpiry")]
    public DateTime AltExpiry { get; set; }

    [JsonPropertyName("altActivation")]
    public DateTime AltActivation { get; set; }

    [JsonPropertyName("nextAlt")]
    public NextAlt NextAlt { get; set; }
  }

  public class Fissure
  {
    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("missionType")]
    public string MissionType { get; set; }

    [JsonPropertyName("tier")]
    public string Tier { get; set; }

    [JsonPropertyName("tierNum")]
    public int TierNum { get; set; }

    [JsonPropertyName("enemy")]
    public string Enemy { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("isStorm")]
    public bool IsStorm { get; set; }
  }

  public class FlashSale
  {
    [JsonPropertyName("item")]
    public string Item { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("discount")]
    public int Discount { get; set; }

    [JsonPropertyName("premiumOverride")]
    public int PremiumOverride { get; set; }

    [JsonPropertyName("isPopular")]
    public bool IsPopular { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("isFeatured")]
    public bool IsFeatured { get; set; }
  }

  public class GlobalUpgrade
  {
    [JsonPropertyName("start")]
    public string Start { get; set; }

    [JsonPropertyName("end")]
    public string End { get; set; }

    [JsonPropertyName("upgrade")]
    public string Upgrade { get; set; }

    [JsonPropertyName("operation")]
    public string Operation { get; set; }

    [JsonPropertyName("operationSymbol")]
    public string OperationSymbol { get; set; }

    [JsonPropertyName("upgradeOperationValue")]
    public int UpgradeOperationValue { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("desc")]
    public string Desc { get; set; }
  }

  public class Attacker
  {
    [JsonPropertyName("reward")]
    public Reward Reward { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("factionKey")]
    public string FactionKey { get; set; }
  }

  public class AttackerReward
  {
    [JsonPropertyName("countedItems")]
    public List<CountedItem> CountedItems { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("credits")]
    public int Credits { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("items")]
    public List<string> Items { get; set; }

    [JsonPropertyName("itemString")]
    public string ItemString { get; set; }
  }

  public class Defender
  {
    [JsonPropertyName("reward")]
    public Reward Reward { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("factionKey")]
    public string FactionKey { get; set; }
  }

  public class DefenderReward
  {
    [JsonPropertyName("countedItems")]
    public List<CountedItem> CountedItems { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("color")]
    public int Color { get; set; }

    [JsonPropertyName("credits")]
    public int Credits { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("items")]
    public List<string> Items { get; set; }

    [JsonPropertyName("itemString")]
    public string ItemString { get; set; }
  }

  public class Invasion
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("attacker")]
    public Attacker Attacker { get; set; }

    [JsonPropertyName("attackerReward")]
    public AttackerReward AttackerReward { get; set; }

    [JsonPropertyName("attackingFaction")]
    public string AttackingFaction { get; set; }

    [JsonPropertyName("completed")]
    public bool Completed { get; set; }

    [JsonPropertyName("completion")]
    public List<double> Completion { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("defender")]
    public Defender Defender { get; set; }

    [JsonPropertyName("defenderReward")]
    public DefenderReward DefenderReward { get; set; }

    [JsonPropertyName("defendingFaction")]
    public string DefendingFaction { get; set; }

    [JsonPropertyName("desc")]
    public string Desc { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("nodeKey")]
    public string NodeKey { get; set; }

    [JsonPropertyName("requiredRuns")]
    public int RequiredRuns { get; set; }

    [JsonPropertyName("rewardTypes")]
    public List<string> RewardTypes { get; set; }

    [JsonPropertyName("startString")]
    public string StartString { get; set; }

    [JsonPropertyName("vsInfestation")]
    public bool VsInfestation { get; set; }
  }

  public class Kuva
  {
    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("enemy")]
    public string Enemy { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("node_type")]
    public string NodeType { get; set; }

    [JsonPropertyName("archwing")]
    public bool Archwing { get; set; }

    [JsonPropertyName("sharkwing")]
    public bool Sharkwing { get; set; }
  }

  public class Translations
  {
    [JsonPropertyName("es")]
    public string Es { get; set; }
  }

  public class News
  {
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("imageLink")]
    public string ImageLink { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("primeAccess")]
    public bool PrimeAccess { get; set; }

    [JsonPropertyName("stream")]
    public bool Stream { get; set; }

    [JsonPropertyName("translations")]
    public Translations Translations { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("update")]
    public bool Update { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("priority")]
    public bool Priority { get; set; }
  }

  public class Params
  {
  }

  public class PossibleChallenge
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("isDaily")]
    public bool IsDaily { get; set; }

    [JsonPropertyName("isElite")]
    public bool IsElite { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("desc")]
    public string Desc { get; set; }

    [JsonPropertyName("reputation")]
    public int Reputation { get; set; }
  }

  public class ActiveChallenge
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("isDaily")]
    public bool IsDaily { get; set; }

    [JsonPropertyName("isElite")]
    public bool IsElite { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("desc")]
    public string Desc { get; set; }

    [JsonPropertyName("reputation")]
    public int Reputation { get; set; }
  }

  public class Nightwave
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("params")]
    public Params Params { get; set; }

    [JsonPropertyName("rewardTypes")]
    public List<string> RewardTypes { get; set; }

    [JsonPropertyName("season")]
    public int Season { get; set; }

    [JsonPropertyName("tag")]
    public string Tag { get; set; }

    [JsonPropertyName("phase")]
    public int Phase { get; set; }

    [JsonPropertyName("possibleChallenges")]
    public List<PossibleChallenge> PossibleChallenges { get; set; }

    [JsonPropertyName("activeChallenges")]
    public List<ActiveChallenge> ActiveChallenges { get; set; }
  }

  public class PersistentEnemy
  {
    [JsonPropertyName("locationTag")]
    public string LocationTag { get; set; }

    [JsonPropertyName("agentType")]
    public string AgentType { get; set; }

    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("healthPercent")]
    public int HealthPercent { get; set; }

    [JsonPropertyName("fleeDamage")]
    public int FleeDamage { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("lastDiscoveredTime")]
    public string LastDiscoveredTime { get; set; }

    [JsonPropertyName("lastDiscoveredAt")]
    public string LastDiscoveredAt { get; set; }

    [JsonPropertyName("isDiscovered")]
    public bool IsDiscovered { get; set; }

    [JsonPropertyName("isUsingTicketing")]
    public bool IsUsingTicketing { get; set; }

    [JsonPropertyName("pid")]
    public string Pid { get; set; }
  }

  public class Simaris
  {
    [JsonPropertyName("target")]
    public string Target { get; set; }

    [JsonPropertyName("isTargetActive")]
    public bool IsTargetActive { get; set; }

    [JsonPropertyName("asString")]
    public string AsString { get; set; }
  }

  public class Variant
  {
    [JsonPropertyName("node")]
    public string Node { get; set; }

    [JsonPropertyName("boss")]
    public string Boss { get; set; }

    [JsonPropertyName("missionType")]
    public string MissionType { get; set; }

    [JsonPropertyName("planet")]
    public string Planet { get; set; }

    [JsonPropertyName("modifier")]
    public string Modifier { get; set; }

    [JsonPropertyName("modifierDescription")]
    public string ModifierDescription { get; set; }
  }

  public class Sortie
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("rewardPool")]
    public string RewardPool { get; set; }

    [JsonPropertyName("variants")]
    public List<Variant> Variants { get; set; }

    [JsonPropertyName("boss")]
    public string Boss { get; set; }

    [JsonPropertyName("faction")]
    public string Faction { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }
  }

  public class CurrentReward
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("cost")]
    public int Cost { get; set; }
  }

  public class Rotation
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("cost")]
    public int Cost { get; set; }
  }

  public class Evergreen
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("cost")]
    public int Cost { get; set; }
  }

  public class Incursions
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }
  }

  public class SteelPath
  {
    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("currentReward")]
    public CurrentReward CurrentReward { get; set; }

    [JsonPropertyName("remaining")]
    public string Remaining { get; set; }

    [JsonPropertyName("rotation")]
    public List<Rotation> Rotation { get; set; }

    [JsonPropertyName("evergreens")]
    public List<Evergreen> Evergreens { get; set; }

    [JsonPropertyName("incursions")]
    public Incursions Incursions { get; set; }
  }

  public class SyndicateMission
  {
    [JsonPropertyName("nodes")]
    public List<string> Nodes { get; set; }

    [JsonPropertyName("eta")]
    public string Eta { get; set; }

    [JsonPropertyName("jobs")]
    public List<Job> Jobs { get; set; }

    [JsonPropertyName("syndicate")]
    public string Syndicate { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }
  }

  public class VallisCycle
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("expiry")]
    public string Expiry { get; set; }

    [JsonPropertyName("timeLeft")]
    public string TimeLeft { get; set; }

    [JsonPropertyName("isWarm")]
    public bool IsWarm { get; set; }
  }

  public class Inventory
  {
    [JsonPropertyName("item")]
    public string Item { get; set; }

    [JsonPropertyName("ducats")]
    public int Ducats { get; set; }

    [JsonPropertyName("credits")]
    public int Credits { get; set; }
  }

  public class VoidTrader
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("activation")]
    public DateTime Activation { get; set; }

    [JsonPropertyName("expiry")]
    public DateTime Expiry { get; set; }

    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("inventory")]
    public List<Inventory> Inventory { get; set; }

    [JsonPropertyName("psId")]
    public string PsId { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("startString")]
    public string StartString { get; set; }

    [JsonPropertyName("endString")]
    public string EndString { get; set; }
  }

  public class WorldState
  {
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }

    //[JsonPropertyName("alerts")]
    //public Alerts Alerts { get; set; }

    //[JsonPropertyName("arbitration")]
    //public Arbitration Arbitration { get; set; }

    //[JsonPropertyName("cetusCycle")]
    //public CetusCycle CetusCycle { get; set; }

    //[JsonPropertyName("constructionProgress")]
    //public ConstructionProgress ConstructionProgress { get; set; }

    //[JsonPropertyName("conclaveChallenges")]
    //public List<ConclaveChallenge> ConclaveChallenges { get; set; }

    //[JsonPropertyName("dailyDeals")]
    //public List<DailyDeal> DailyDeals { get; set; }

    //[JsonPropertyName("darkSectors")]
    //public List<DarkSector> DarkSectors { get; set; }

    //[JsonPropertyName("earthCycle")]
    //public EarthCycle EarthCycle { get; set; }

    //[JsonPropertyName("events")]
    //public List<Event> Events { get; set; }

    //[JsonPropertyName("fissures")]
    //public List<Fissure> Fissures { get; set; }

    //[JsonPropertyName("flashSales")]
    //public List<FlashSale> FlashSales { get; set; }

    //[JsonPropertyName("globalUpgrades")]
    //public List<GlobalUpgrade> GlobalUpgrades { get; set; }

    //[JsonPropertyName("invasions")]
    //public List<Invasion> Invasions { get; set; }

    //[JsonPropertyName("kuva")]
    //public Kuva Kuva { get; set; }

    [JsonPropertyName("news")]
    public List<News> News { get; set; }

    //[JsonPropertyName("nightwave")]
    //public Nightwave Nightwave { get; set; }

    //[JsonPropertyName("persistentEnemies")]
    //public List<PersistentEnemy> PersistentEnemies { get; set; }

    //[JsonPropertyName("simaris")]
    //public Simaris Simaris { get; set; }

    //[JsonPropertyName("sortie")]
    //public Sortie Sortie { get; set; }

    //[JsonPropertyName("steelPath")]
    //public SteelPath SteelPath { get; set; }

    //[JsonPropertyName("syndicateMissions")]
    //public List<SyndicateMission> SyndicateMissions { get; set; }

    //[JsonPropertyName("vallisCycle")]
    //public VallisCycle VallisCycle { get; set; }

    //[JsonPropertyName("voidTrader")]
    //public VoidTrader VoidTrader { get; set; }
  }
}