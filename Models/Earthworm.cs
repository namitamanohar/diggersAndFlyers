namespace DiggersAndFlyers {
  public class Earthworm : IDigging {
    public string name { get; set; }
    public string color { get; set; }
    public string countyOfOrigin { get; set; }
    public void Dig () {

    }

    public override string ToString () {
      return ($"{name} is a digger");
    }
  }
}