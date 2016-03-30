#pragma strict
var color1: Color = Color.red;
var color2: Color = Color.red;
var lineRenderer: LineRenderer;

function Start () {
	lineRenderer = gameObject.AddComponent(LineRenderer);
	lineRenderer.material = new Material(Shader.Find("ParticleGlow"/*"Particles/Additive"*/));
	lineRenderer.SetColors(color1, color2);
	lineRenderer.SetWidth(0.02,0.02);
	lineRenderer.SetVertexCount(2);
}

function LateUpdate () {
	var origin = transform.position;
	var direction = transform.forward;
	var endpoint = origin + direction * 100000;
	var hit:RaycastHit;
	
	lineRenderer.SetPosition(0,origin);
	
	if(Physics.Raycast(origin, direction, hit))
	lineRenderer.SetPosition(1,hit.point);
}