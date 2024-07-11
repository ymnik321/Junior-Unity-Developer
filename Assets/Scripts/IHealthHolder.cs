public interface IHealthHolder
{
    float HealthPoints { get; }
    void ChangeHp(float step);
}
